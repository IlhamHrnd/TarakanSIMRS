using Tarakan.EntitySpaces.Helper;

namespace Tarakan.EntitySpaces.Generated
{
    public partial class MergeBilling
    {
        [Obsolete]
        public static string PlafondProgress(string regNo, bool isModeText)
        {
            var ap = new AppParameter();
            var isEmrListShowPlafondProgress = ap.LoadByPrimaryKey("IsEmrListShowPlafondProgress") && Converter.StringToBool(ap.ParameterValue);
            if (!isEmrListShowPlafondProgress)
                return string.Empty;

            decimal tpatient = 0;
            decimal tguarantor = 0;
            decimal totalPlafond = 0;

            var usedInPercent = PlafondValueUsedInPercentlue(regNo, ref tguarantor, ref tpatient, ref totalPlafond);
            decimal costDifferenct = totalPlafond - tguarantor;
            if (usedInPercent == 0) return string.Empty;

            string result = isModeText
                ? $@"<table style='font-weight:bold;'>
                        <tr>
                            <td style='width:100px;'>Plafond Progress</td><td>&nbsp;:&nbsp;</td>
                            <td>
                                <div title='G: [{tguarantor:N2}] P: [{(decimal)0:N2}] F: [{totalPlafond:N2}]' style='background:black;width: 100%; padding: 1px'>
                                    <div style='background:{(usedInPercent > 100 ? "red" : usedInPercent > 75 ? "yellow" : "green")};color:Black;width: {(usedInPercent > 100 ? 100 : usedInPercent)}%'>{(usedInPercent > 300 ? ">300%" : $"{usedInPercent:n2}%")}</div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style='width:100px;'>Plafond</td><td>&nbsp;:&nbsp;</td>
                            <td style='width:70px;text-align:right;'>{totalPlafond:n}</td>
                        </tr>
                        <tr>
                            <td style='width:100px;'>Billing</td><td>&nbsp;:&nbsp;</td>
                            <td style='width:70px;text-align:right;'>{tguarantor + 0:n}</td>
                        </tr>
                        <tr>
		                    <td style='width:100px;'>Cost Different</td><td>&nbsp;:&nbsp;</td>
		                    <td style='width:70px;text-align:right;'>{costDifferenct:n}</td>
	                    </tr>
                    </table>"
                : $@"<div title='G: [{tguarantor:N2}] P: [{(decimal)0:N2}] F: [{totalPlafond:N2}]' style='background:black;width: 100%; padding: 1px'>
                        <div style='background:{(usedInPercent > 100 ? "red" : usedInPercent > 75 ? "yellow" : "green")};color:Black;width: {(usedInPercent > 100 ? 100 : usedInPercent)}%'>{(usedInPercent > 300 ? ">300%" : $"{usedInPercent:n2}%")}</div>
                    </div>";
            return result;
        }

        [Obsolete]
        private static decimal PlafondValueUsedInPercentlue(string regno, ref decimal tguarantor, ref decimal tpatient, ref decimal totalPlafond)
        {
            var r = new Registration();
            var rQ = new RegistrationQuery("rQ");
            rQ.Select(rQ.SRRegistrationType, rQ.PlavonAmount, rQ.GuarantorID, rQ.ApproximatePlafondAmount, rQ.SRBussinesMethod, rQ.IsGlobalPlafond)
                .Where(rQ.RegistrationNo == regno);
            r.Load(rQ);

            if (!GuarantorBridging.BringdingBpjs().Contains(r.GuarantorID))
                return 0;

            decimal cobPlafond = AdditionalPlafond(regno);
            decimal total = TotalPlafond(r.SRRegistrationType, r.PlavonAmount, r.GuarantorID, r.ApproximatePlafondAmount, cobPlafond);
            decimal estimate = PlafondEstimate(regno);

            if (total > 0)
                totalPlafond = total;
            else if (estimate > 0)
                totalPlafond = estimate;
            else
                totalPlafond = 1;
            var regNos = Registration.GetMergeRegistration(regno);
            var g = new Guarantor();
            g.LoadByPrimaryKey(r.GuarantorID);

            CostCalculation.GetBillingTotalEMR(regNos, r.SRBussinesMethod, 0, out tpatient, out tguarantor, g, r.IsGlobalPlafond ?? false);
            var totalRemain = tguarantor + tpatient;
            return (totalRemain / totalPlafond) * (decimal)100;
        }

        private static decimal AdditionalPlafond(string regNo)
        {
            var rgQ = new RegistrationGuarantorQuery("rgQ");
            var rgColl = new RegistrationGuarantorCollection();

            rgQ.Select(rgQ.PlafondAmount).Where(rgQ.RegistrationNo == regNo);
            rgColl.Load(rgQ);
            return rgColl.Sum(r => r.PlafondAmount ?? 0);
        }

        private static decimal TotalPlafond(string regType, decimal? plafond, string guarID, decimal? approximatePlafondAmount, decimal additionalPlafond)
        {
            if (regType == "IPR")
            {
                decimal plafondAmt = plafond ?? 0;
                if (GuarantorBridging.BringdingBpjs().Contains(guarID) && plafondAmt == 0)
                    plafondAmt = (decimal)(approximatePlafondAmount == null ? 0 : approximatePlafondAmount);

                return plafondAmt + additionalPlafond;
            }
            else
            {
                var ap = new AppParameter();
                if (!ap.LoadByPrimaryKey("NonInPatientBpjsPlafond"))
                    return 0;

                var inPatientPlafond = Converter.StringToDecimal(ap.ParameterValue, 0);
                return inPatientPlafond > 0 ? inPatientPlafond : (approximatePlafondAmount ?? 0);
            }
        }

        private static decimal PlafondEstimate(string regNo)
        {
            var rea = new RegistrationEstimateAmount();
            return rea.LoadByPrimaryKey(regNo) ? (decimal)(rea.PatientAmount == null ? 0 : rea.PatientAmount) : 0;
        }
    }
}
