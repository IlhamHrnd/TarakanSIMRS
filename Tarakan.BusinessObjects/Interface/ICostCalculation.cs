namespace Tarakan.BusinessObjects.Interface
{
    public interface ICostCalculation
    {
        void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, bool isGlobalPlafond, string guarId, bool IsIncludeAdminValue, out decimal patientAmount, out decimal guarantorAmount);
    }
}
