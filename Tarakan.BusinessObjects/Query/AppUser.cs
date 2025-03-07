using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppUser : IAppUser
    {
        private readonly AppDbContext _context;
        public AppUser(AppDbContext context)
        {
            _context = context;
        }

        public AppUserDto LoadByPrimaryKey(string userId, string password)
        {
            var result = new AppUserDto();
            var au = new EntitySpaces.Generated.AppUser();

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
                return result;

            if (!au.LoadByPrimaryKey(userId, password))
                return result;

            result = new AppUserDto
            {
                UserId = au.UserID,
                UserName = au.UserName,
                Srlanguage = au.SRLanguage,
                ActiveDate = au.ActiveDate ?? new DateTime(),
                ExpireDate = au.ExpireDate ?? new DateTime(),
                LastUpdateDateTime = au.LastUpdateDateTime,
                LastUpdateByUserId = au.LastUpdateByUserID,
                ParamedicId = au.ParamedicID,
                ServiceUnitId = au.ServiceUnitID,
                LicenseNo = au.LicenseNo,
                PersonId = au.PersonID,
                Email = au.Email,
                IsLocked = au.IsLocked,
                SruserType = au.SRUserType,
                CashManagementNo = au.CashManagementNo,
                SignatureImage = au.SignatureImage,
                LastCounterName = au.LastCounterName,
                PasswordMd5 = au.PasswordMd5,
                LastLogin = au.LastLogin,
                EsignNik = au.ESignNik
            };

            return result;
        }
    }
}
