using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class BaseQuery
    {
        protected readonly AppDbContext _context;

        public BaseQuery(AppDbContext context)
        {
            _context = context;
        }
    }
}
