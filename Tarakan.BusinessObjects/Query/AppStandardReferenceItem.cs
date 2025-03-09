using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppStandardReferenceItem : IAppStandardReferenceItem
    {
        private readonly AppDbContext _context;
        public AppStandardReferenceItem(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<AppStandardReferenceItemDto>> GetReferenceItem(string referenceId, bool? isActive, bool? isUsedBySystem)
        {
            var query = _context.AppStandardReferenceItems.AsQueryable()
                .Where(asri => asri.StandardReferenceId == referenceId);

            if (isActive.HasValue)
                query = query.Where(asri => asri.IsActive == isActive.Value);

            if (isUsedBySystem.HasValue)
                query = query.Where(asri => asri.IsUsedBySystem == isUsedBySystem.Value);

            return query.OrderBy(asri => asri.ItemName)
                .Select(asri => new AppStandardReferenceItemDto
                {
                    StandardReferenceID = asri.StandardReferenceId,
                    ItemID = asri.ItemId,
                    ItemName = asri.ItemName
                }).ToListAsync();


        }
    }
}
