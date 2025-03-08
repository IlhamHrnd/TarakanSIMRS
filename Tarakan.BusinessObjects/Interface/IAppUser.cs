using System.Data;
using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IAppUser
    {
        AppUserDto LoadByPrimaryKey(string userId, string password);
        DataTable AppUserGroupProgramDtos(string userId);
    }
}
