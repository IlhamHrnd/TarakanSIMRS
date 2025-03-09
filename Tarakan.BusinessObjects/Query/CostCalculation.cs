using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class CostCalculation : ICostCalculation
    {
        private readonly IAppParameter _appParameter;
        private readonly IGuarantorBridging _guarantorBridging;
        public CostCalculation(IAppParameter appParameter, IGuarantorBridging guarantorBridging)
        {
            _appParameter = appParameter;
            _guarantorBridging = guarantorBridging;
        }

        public void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, out decimal patientAmount, out decimal guarantorAmount, EntitySpaces.Generated.Guarantor g, bool isGlobalPlafond)
        {
            var ccQ = new EntitySpaces.Generated.CostCalculationQuery("ccQ");
            var tcQ = new EntitySpaces.Generated.TransChargesQuery("tcQ");

            ccQ.Select(ccQ.PatientAmount.Sum().As("PatientAmount"), ccQ.GuarantorAmount.Sum().As("GuarantorAmount"))
                .InnerJoin(tcQ).On(tcQ.TransactionNo == ccQ.TransactionNo)
                .Where(ccQ.RegistrationNo.In(regNos), tcQ.IsVoid != false);
            var dtb = ccQ.LoadDataTable();
            decimal? patient = 0, grr = 0;
            if (dtb.Rows.Count > 0)
            {
                patient = dtb.Rows[0]["PatientAmount"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["PatientAmount"]) : 0;
                grr = dtb.Rows[0]["GuarantorAmount"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["GuarantorAmount"]) : 0;
            }

            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            rQ.Where(rQ.RegistrationNo.In(regNos));
            rQ.Select(rQ.PatientAdm.Sum().As("PatientAdm"),
                rQ.GuarantorAdm.Sum().As("GuarantorAdm"),
                rQ.DiscAdmGuarantor.Sum().As("DiscAdmGuarantor"),
                rQ.DiscAdmPatient.Sum().As("DiscAdmPatient")
                );
            var dtbReg = rQ.LoadDataTable();
            decimal? admin = 0;
            if (dtbReg.Rows.Count > 0)
                admin = (dtbReg.Rows[0]["PatientAdm"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["PatientAdm"]) : 0) + (dtbReg.Rows[0]["GuarantorAdm"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["GuarantorAdm"]) : 0) +
                    (dtbReg.Rows[0]["DiscAdmGuarantor"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["DiscAdmGuarantor"]) : 0) + (dtbReg.Rows[0]["DiscAdmPatient"] != DBNull.Value ? Convert.ToDecimal(dtb.Rows[0]["DiscAdmPatient"]) : 0);

            if (g.GuarantorID == _appParameter.ParameterString("SelfGuarantor"))
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
                bool isBridging = _appParameter.ParameterBoolean("IsBridgingBillingBpjs") && _guarantorBridging.BringdingBpjs().Length > 0;

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
