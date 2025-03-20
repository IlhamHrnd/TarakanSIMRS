using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppStandardReferenceItem : BaseQuery, IAppStandardReferenceItem
    {
        public AppStandardReferenceItem(AppDbContext context) : base(context)
        {

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
                        ItemName = asri.ItemName ?? string.Empty
                }).ToListAsync();
        }

        public string GetItemName(string referenceId, string itemId)
        {
            if (string.IsNullOrEmpty(referenceId) || string.IsNullOrEmpty(itemId))
                return string.Empty;

            var query = (from asri in _context.AppStandardReferenceItems
                         where asri.StandardReferenceId == referenceId && asri.ItemId == itemId
                         select asri).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.StandardReferenceId) || string.IsNullOrWhiteSpace(query.ItemName))
                return string.Empty;

            return query.ItemName;
        }

        public AppStandardReferenceItemDto LoadByPrimaryKey(string referenceId, string itemId)
        {
            if (string.IsNullOrEmpty(referenceId) || string.IsNullOrEmpty(itemId))
                return new AppStandardReferenceItemDto();

            var query = (from asri in _context.AppStandardReferenceItems
                        where asri.StandardReferenceId == referenceId && asri.ItemId == itemId
                        select new { asri.StandardReferenceId, asri.ItemId, asri.ItemName, asri.NumericValue }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.StandardReferenceId))
                return new AppStandardReferenceItemDto();

            return new AppStandardReferenceItemDto
            {
                StandardReferenceID = query.StandardReferenceId,
                ItemID = query.ItemId,
                ItemName = query.ItemName,
                NumericValue = Convert.ToInt32(query.NumericValue)
            };
        }
    }
}
