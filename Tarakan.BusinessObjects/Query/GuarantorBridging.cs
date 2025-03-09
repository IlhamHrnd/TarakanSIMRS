using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class GuarantorBridging : IGuarantorBridging
    {
        public string[] BringdingBpjs()
        {
            return EntitySpaces.Generated.GuarantorBridging.BringdingBpjs();
        }
    }
}
