using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class GuarantorBridging : BaseQuery, IGuarantorBridging
    {
        public GuarantorBridging(AppDbContext context) : base(context)
        {

        }

        public string[] BringdingBpjs()
        {
            var query = _context.GuarantorBridgings
                .Where(gb => Const.Bpjstnipolripns.Contains(gb.SrbridgingType))
                .Distinct().ToList();

            return query.Count > 0 ? [..query.Select(g => g.GuarantorId)] : [string.Empty];
        }
    }
}
