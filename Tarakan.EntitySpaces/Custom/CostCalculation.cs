using Tarakan.EntitySpaces.Helper;

namespace Tarakan.EntitySpaces.Generated
{
    public partial class CostCalculation
    {
        public static void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, out decimal patientAmount, out decimal guarantorAmount, EntitySpaces.Generated.Guarantor g, bool isGlobalPlafond)
        {
            var ccQ = new CostCalculationQuery("ccQ");
            var vtQ = new VwTransactionQuery("vtQ");

            ccQ.Select(ccQ.PatientAmount.Sum().As("PatientAmount"), ccQ.GuarantorAmount.Sum().As("GuarantorAmount"))
                .InnerJoin(vtQ).On(vtQ.TransactionNo == ccQ.TransactionNo)
                .Where(ccQ.RegistrationNo.In(regNos));
            var dtb = ccQ.LoadDataTable();
            decimal? patient = 0, grr = 0;
            if (dtb.Rows.Count > 0)
            {
                patient = dtb.Rows[0]["PatientAmount"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["PatientAmount"]) : 0;
                grr = dtb.Rows[0]["GuarantorAmount"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["GuarantorAmount"]) : 0;
            }

            var rQ = new RegistrationQuery("rQ");
            rQ.Where(rQ.RegistrationNo.In(regNos));
            rQ.Select(rQ.PatientAdm.Sum().As("PatientAdm"),
                rQ.GuarantorAdm.Sum().As("GuarantorAdm"),
                rQ.DiscAdmGuarantor.Sum().As("DiscAdmGuarantor"),
                rQ.DiscAdmPatient.Sum().As("DiscAdmPatient")
                );
            var dtbReg = rQ.LoadDataTable();
            decimal? admin = 0;
            if (dtbReg.Rows.Count > 0)
            {
                var patientAdm = dtbReg.Rows[0]["PatientAdm"] != DBNull.Value ? Convert.ToDecimal(dtbReg.Rows[0]["PatientAdm"]) : 0;
                var guarantorAdm = dtbReg.Rows[0]["GuarantorAdm"] != DBNull.Value ? Convert.ToDecimal(dtbReg.Rows[0]["GuarantorAdm"]) : 0;
                var discAdmGuarantor = dtbReg.Rows[0]["DiscAdmGuarantor"] != DBNull.Value ? Convert.ToDecimal(dtbReg.Rows[0]["DiscAdmGuarantor"]) : 0;
                var discAdmPatient = dtbReg.Rows[0]["DiscAdmPatient"] != DBNull.Value ? Convert.ToDecimal(dtbReg.Rows[0]["DiscAdmPatient"]) : 0;
                admin = patientAdm + guarantorAdm + discAdmGuarantor + discAdmPatient;
            }

            var ap = new AppParameter();
            var selfGuarantor = ap.LoadByPrimaryKey("SelfGuarantor") ? ap.ParameterValue : string.Empty;
            if (g.GuarantorID == selfGuarantor)
                patient += admin;
            else
            {
                if (g.IsIncludeAdminValue ?? false)
                    grr += admin;
                else
                    patient += admin;
            }

            if (isGlobalPlafond && (plafonAmount > 0))
            {
                ap = new AppParameter();
                bool isBridging = (ap.LoadByPrimaryKey("IsBridgingBillingBpjs") ? Converter.StringToBool(ap.ParameterValue) : false) && GuarantorBridging.BringdingBpjs().Length > 0;

                if (isBridging)
                {
                    grr = plafonAmount;
                    patient = 0;
                }
                else
                {
                    if (patient + grr >= plafonAmount)
                    {
                        patient = (patient + grr) - plafonAmount;
                        grr = plafonAmount;
                    }
                    else
                    {
                        grr = patient + grr;
                        patient = 0;
                    }
                }
            }

            patientAmount = patient ?? 0;
            guarantorAmount = grr ?? 0;
        }
    }
}
