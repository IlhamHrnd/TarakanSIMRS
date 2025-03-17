using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationPathway : BaseQuery, IRegistrationPathway
    {
        public RegistrationPathway(AppDbContext context) : base(context)
        {
            
        }

        public string GetRegistrationPathwayName(string regNo)
        {
            var query = (from rp in _context.RegistrationPathways
                         join p in _context.Pathways
                         on rp.PathwayId equals p.PathwayId
                         where rp.RegistrationNo == regNo && rp.PathwayId != string.Empty
                         select new { p.PathwayName, rp.PathwayStatus }).FirstOrDefault();
            return query != null
                ? $"{query.PathwayName} ({(query.PathwayStatus == "A" ? "ACCEPT" : (query.PathwayStatus == "F" ? "FAIL" : "-"))})"
                : "-";
        }
    }
}
