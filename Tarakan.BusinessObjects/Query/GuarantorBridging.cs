using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class GuarantorBridging : IGuarantorBridging
    {
        public string[] BringdingBpjs()
        {
            var gbQ = new EntitySpaces.Generated.GuarantorBridgingQuery("gbQ");
            var gbColl = new EntitySpaces.Generated.GuarantorBridgingCollection();
            gbQ.Select(gbQ.GuarantorID)
                .Where(gbQ.SRBridgingType.In(Const.Bpjs, Const.Bpjstnipolripns, Const.Bpjspasienumum))
                .Distinct();
            gbColl.Load(gbQ);
            return gbColl.Count > 0 ? [.. gbColl.Select(g => g.GuarantorID)] : [string.Empty];
        }
    }
}
