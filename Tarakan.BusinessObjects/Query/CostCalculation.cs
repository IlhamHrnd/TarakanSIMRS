using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class CostCalculation : BaseQuery, ICostCalculation
    {
        private readonly IAppParameter _appParameter;
        private readonly IGuarantorBridging _guarantorBridging;
        public CostCalculation(AppDbContext context, IAppParameter appParameter, IGuarantorBridging guarantorBridging) : base(context)
        {
            _appParameter = appParameter;
            _guarantorBridging = guarantorBridging;
        }

        public void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, bool isGlobalPlafond, string guarId, bool IsIncludeAdminValue, out decimal patientAmount, out decimal guarantorAmount)
        {
            var ccQuery = _context.CostCalculations
                .Join(_context.VwTransactions, cc => cc.TransactionNo, vt => vt.TransactionNo, (cc, vt) => cc)
                .Where(cc => regNos.Contains(cc.RegistrationNo))
                .Select(cc => new CostCalculationDto
                {
                    PatientAmount = cc.PatientAmount,
                    GuarantorAmount = cc.GuarantorAmount
                }).ToList();

            decimal? patient = 0, grr = 0;
            if (ccQuery.Count > 0)
            {
                patient = ccQuery.Sum(cc => cc.PatientAmount);
                grr = ccQuery.Sum(cc => cc.GuarantorAmount);
            }

            var rQuery = _context.Registrations
                .Where(r => regNos.Contains(r.RegistrationNo))
                .Select(r => new RegistrationDto
                {
                    PatientAdm = r.PatientAdm,
                    GuarantorAdm = r.GuarantorAdm,
                    DiscAdmPatient = r.DiscAdmPatient,
                    DiscAdmGuarantor = r.DiscAdmGuarantor
                }).ToList();
            decimal? admin = rQuery.Count > 0 ? rQuery.Sum(r => r.PatientAdm) + rQuery.Sum(r => r.GuarantorAdm) + rQuery.Sum(r => r.DiscAdmPatient) + rQuery.Sum(r => r.DiscAdmGuarantor) : 0;

            if (guarId == _appParameter.ParameterString("SelfGuarantor"))
                patient += admin;
            else
            {
                if (IsIncludeAdminValue)
                    grr += admin;
                else
                    patient += admin;
            }

            if (isGlobalPlafond && plafonAmount > 0)
            {
                if (_appParameter.ParameterBoolean("IsBridgingBillingBpjs") && _guarantorBridging.BringdingBpjs().Length > 0)
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
