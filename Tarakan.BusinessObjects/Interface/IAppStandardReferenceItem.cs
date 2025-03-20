using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IAppStandardReferenceItem
    {
        Task<List<AppStandardReferenceItemDto>> GetReferenceItem(string referenceId, bool? isActive, bool? isUsedBySystem);
        string GetItemName(string referenceId, string itemId);
        AppStandardReferenceItemDto LoadByPrimaryKey(string referenceId, string itemId);
    }
}
