namespace Tarakan.BusinessObjects.Interface
{
    public interface ICostCalculation
    {
        void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, out decimal patientAmount, out decimal guarantorAmount, EntitySpaces.Generated.Guarantor g, bool isGlobalPlafond);
    }
}
