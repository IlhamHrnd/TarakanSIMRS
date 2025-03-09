using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class CostCalculation : ICostCalculation
    {
        public void GetBillingTotalEMR(string[] regNos, string srBusinessMethod, decimal plafonAmount, out decimal patientAmount, out decimal guarantorAmount, EntitySpaces.Generated.Guarantor g, bool isGlobalPlafond)
        {
            EntitySpaces.Generated.CostCalculation.GetBillingTotalEMR(regNos, srBusinessMethod, plafonAmount, out patientAmount, out guarantorAmount, g, isGlobalPlafond);
        }
    }
}
