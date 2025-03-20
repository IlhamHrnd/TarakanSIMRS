using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppUser : BaseQuery, IAppUser
    {
        public AppUser(AppDbContext context) : base(context)
        {

        }

        public AppUserDto LoadByPrimaryKey(string userId, string password)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
                return new AppUserDto();

            var query = (from au in _context.AppUsers
                         where au.UserId == userId && au.Password == password
                         select au).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.UserId))
                return new AppUserDto
                {
                    au = new EntityFramework.Models.AppUser()
                };

            return new AppUserDto
            {
                au = new EntityFramework.Models.AppUser
                {
                    UserId = query.UserId,
                    UserName = query.UserName,
                    Srlanguage = query.Srlanguage,
                    ActiveDate = query.ActiveDate,
                    ExpireDate = query.ExpireDate,
                    LastUpdateDateTime = query.LastUpdateDateTime,
                    LastUpdateByUserId = query.LastUpdateByUserId ?? string.Empty,
                    ParamedicId = query.ParamedicId ?? string.Empty,
                    ServiceUnitId = query.ServiceUnitId ?? string.Empty,
                    LicenseNo = query.LicenseNo ?? string.Empty,
                    PersonId = query.PersonId,
                    Email = query.Email ?? string.Empty,
                    IsLocked = query.IsLocked,
                    SruserType = query.SruserType ?? string.Empty,
                    CashManagementNo = query.CashManagementNo ?? string.Empty,
                    SignatureImage = query.SignatureImage ?? [],
                    LastCounterName = query.LastCounterName ?? string.Empty,
                    PasswordMd5 = query.PasswordMd5 ?? string.Empty,
                    LastLogin = query.LastLogin,
                    EsignNik = query.EsignNik ?? string.Empty
                }
            };
        }

        public string GetUsername(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return string.Empty;

            var query = (from au in _context.AppUsers
                        where au.UserId == userId
                        select new { au.UserId, au.UserName }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.UserName))
                return string.Empty;

            return query.UserName;
        }

        public AppUserDto AppUserLoad(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return new AppUserDto();

            var query = (from au in _context.AppUsers
                         where au.UserId == userId
                         select new { au.UserId, au.UserName, au.ServiceUnitId, au.ParamedicId, au.SruserType }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.UserName))
                return new AppUserDto
                {
                    au = new EntityFramework.Models.AppUser()
                };

            return new AppUserDto
            {
                au = new EntityFramework.Models.AppUser
                {
                    UserId = query.UserId,
                    UserName = query.UserName,
                    ServiceUnitId = query.ServiceUnitId,
                    ParamedicId = query.ParamedicId,
                    SruserType = query.SruserType
                }
            };
        }

        public string AppUserString(string appUserId, string defaultString)
        {
            return !string.IsNullOrEmpty(appUserId) ? appUserId: defaultString;
        }
    }
}