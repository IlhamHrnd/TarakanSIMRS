using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IParamedic
    {
        string GetParamedicName(string paramedicID);
        Task<List<ParamedicDto>> GetParamedic(bool? isActive);
    }
}
