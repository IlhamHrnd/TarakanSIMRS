namespace Tarakan.EntitySpaces.Generated
{
    public partial class GuarantorBridging
    {
        public static string[] BringdingBpjs()
        {
            var gbQ = new GuarantorBridgingQuery("gbQ");
            var gbColl = new GuarantorBridgingCollection();
            gbQ.Select(gbQ.GuarantorID)
                .Where(gbQ.SRBridgingType.In("BridgingType-001", "BridgingType-004", "BridgingType-005"))
                .Distinct();
            gbColl.Load(gbQ);
            return gbColl.Count > 0 ? [.. gbColl.Select(g => g.GuarantorID)] : [string.Empty];
        }
    }
}
