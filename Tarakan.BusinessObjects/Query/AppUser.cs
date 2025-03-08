using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class AppUser : IAppUser
    {
        public AppUser()
        {

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

        public DataTable AppUserGroupProgramDtos(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                return new DataTable();

            var auQ = new EntitySpaces.Generated.AppUserQuery("auQ");
            var augpQ = new EntitySpaces.Generated.AppUserGroupProgramQuery("augpQ");
            var auugQ = new EntitySpaces.Generated.AppUserUserGroupQuery("auugQ");

            auQ.Select(auQ.UserID, auugQ.UserGroupID, augpQ.ProgramID, augpQ.IsUserGroupAddAble, augpQ.IsUserGroupEditAble, augpQ.IsUserGroupDeleteAble, augpQ.IsUserGroupApprovalAble, augpQ.IsUserGroupUnApprovalAble,
                augpQ.IsUserGroupUnVoidAble, augpQ.IsUserGroupVoidAble, augpQ.IsUserGroupExportAble, augpQ.IsUserGroupCrossUnitAble, augpQ.IsUserGroupPowerUserAble)
                .InnerJoin(auugQ).On(auugQ.UserID == auQ.UserID)
                .InnerJoin(augpQ).On(augpQ.UserGroupID == auugQ.UserGroupID)
                .Where(auQ.UserID == userId);
            return auQ.LoadDataTable();
        }
    }
}