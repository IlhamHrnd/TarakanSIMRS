using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IServiceUnit
    {
        string GetServiceUnitName(string suId);
        List<ServiceUnitDto> GetServiceUnit(string userId, string srRegistrationType, bool? isActive);
    }
}
