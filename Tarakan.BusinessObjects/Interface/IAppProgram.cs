using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IAppProgram
    {
        AppProgramDto LoadAppProgram(string programId);
        bool IsUserProgramAllow(string userId, string programId);
    }
}
