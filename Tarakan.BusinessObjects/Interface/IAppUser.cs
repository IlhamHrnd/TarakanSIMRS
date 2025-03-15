using System.Data;
using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IAppUser
    {
        AppUserDto LoadByPrimaryKey(string userId, string password);
        string GetUsername(string userId);
        AppUserDto AppUserLoad(string userId);
        string AppUserString(string appUserId, string defaultString);
    }
}
