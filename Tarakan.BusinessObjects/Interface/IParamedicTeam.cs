using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IParamedicTeam
    {
        List<ParamedicTeamDto> GetParamedicTeam(string regNo);
    }
}
