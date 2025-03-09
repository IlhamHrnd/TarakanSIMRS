using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class Mergebilling : IMergeBilling
    {
        private readonly IGuarantorBridging _guarantorBridging;
        private readonly IAppParameter _appParameter;
        private readonly IRegistration _registration;
        private readonly ICostCalculation _costCalculation;
        public Mergebilling(IGuarantorBridging guarantorBridging, IAppParameter appParameter, IRegistration registration, ICostCalculation costCalculation)
        {
            _guarantorBridging = guarantorBridging;
            _appParameter = appParameter;
            _registration = registration;
            _costCalculation = costCalculation;
        }

        public string PlafondProgress(string regNo, bool isModeText)
        {
            if (!_appParameter.ParameterBoolean("IsEmrListShowPlafondProgress"))
                return string.Empty;

            decimal tpatient = 0;
            decimal tguarantor = 0;
            decimal totalPlafond = 0;

            var usedInPercent = PlafondValueUsedInPercentlue(regNo, ref tguarantor, ref tpatient, ref totalPlafond);
            decimal costDifferenct = totalPlafond - tguarantor;
            if (usedInPercent == 0) return string.Empty;

            if (isModeText)
                return string.Format(@"<table style='font-weight:bold;'>
                            <tr>
                                <td style='width:70px;'>Plafond</td><td>&nbsp;:&nbsp;</td>
                                <td style='width:70px;text-align:right;'>{0:n}</td>
                            </tr>
                            <tr>
                                <td>Billing</td><td>&nbsp;:&nbsp;</td>
                                <td style='width:70px;text-align:right;'>{1:n}</td>
                            </tr>
                        </table>", totalPlafond, tguarantor + tpatient);
            else
                return string.Format(@"<div title='G: [{3:N2}] P: [{4:N2}] F: [{5:N2}]' style='background:black;width: 100%; padding: 1px'>
                            <div style='background:{0};color:Black;width: {1}%'>{2}</div>
                        </div>",
                            usedInPercent > 100 ? "red" : usedInPercent > 75 ? "yellow" : "green",
                            usedInPercent > 100 ? 100 : usedInPercent,
                            usedInPercent > 300 ? ">300%" : string.Format("{0:n2}%", usedInPercent),
                            tguarantor,
                            tpatient,
                            totalPlafond);
        }

        #region Plafond
        private decimal PlafondValueUsedInPercentlue(string regno, ref decimal tguarantor, ref decimal tpatient, ref decimal totalPlafond)
        {
            var r = new EntitySpaces.Generated.Registration();
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            rQ.Select(rQ.SRRegistrationType, rQ.PlavonAmount, rQ.GuarantorID, rQ.ApproximatePlafondAmount, rQ.SRBussinesMethod, rQ  .IsGlobalPlafond)
                .Where(rQ.RegistrationNo == regno);
            r.Load(rQ);

            if (!_guarantorBridging.BringdingBpjs().Contains(r.GuarantorID))
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
            var regNos = _registration.GetMergeRegistration(regno);
            var g = new EntitySpaces.Generated.Guarantor();
            g.LoadByPrimaryKey(r.GuarantorID);

            _costCalculation.GetBillingTotalEMR(regNos, r.SRBussinesMethod, 0, out tpatient, out tguarantor, g, r.IsGlobalPlafond ?? false);
            var totalRemain = tguarantor + tpatient;
            return (totalRemain / totalPlafond) * (decimal)100;
        }
        private decimal AdditionalPlafond(string regNo)
        {
            var rgQ = new EntitySpaces.Generated.RegistrationGuarantorQuery("rgQ");
            var rgColl = new EntitySpaces.Generated.RegistrationGuarantorCollection();

            rgQ.Select(rgQ.PlafondAmount).Where(rgQ.RegistrationNo == regNo);
            rgColl.Load(rgQ);
            return rgColl.Sum(r => r.PlafondAmount ?? 0);
        }

        private decimal TotalPlafond(string regType, decimal? plafond, string guarID, decimal? approximatePlafondAmount, decimal additionalPlafond)
        {
            if (regType == Const.Inpatient)
            {
                decimal plafondAmt = plafond ?? 0;
                if (_guarantorBridging.BringdingBpjs().Contains(guarID) && plafondAmt == 0)
                    plafondAmt = (decimal)(approximatePlafondAmount == null ? 0 : approximatePlafondAmount);

                return plafondAmt + additionalPlafond;
            }
            else
            {
                var ap = new EntitySpaces.Generated.AppParameter();
                if (!ap.LoadByPrimaryKey("NonInPatientBpjsPlafond"))
                    return 0;

                var inPatientPlafond = Converter.StringToDecimal(ap.ParameterValue, 0);

                return inPatientPlafond > 0 ? inPatientPlafond : (approximatePlafondAmount ?? 0);
            }
        }

        private decimal PlafondEstimate(string regNo)
        {
            var rea = new EntitySpaces.Generated.RegistrationEstimateAmount();
            return rea.LoadByPrimaryKey(regNo) ? (decimal)(rea.PatientAmount == null ? 0 : rea.PatientAmount) : 0;
        }
        #endregion
    }
}
