using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppProgram : IAppProgram
    {
        private readonly AppDbContext _context;

        public AppProgram(AppDbContext context)
        {
            _context = context;
        }

        public AppProgramDto LoadAppProgram(string programId)
        {
            if (string.IsNullOrWhiteSpace(programId))
                return new AppProgramDto();

            var ap = new EntitySpaces.Generated.AppProgram();
            if (!ap.LoadByPrimaryKey(programId))
                return new AppProgramDto();

            return new AppProgramDto
            {
                ProgramId = ap.ProgramID,
                ProgramName = ap.ProgramName,
                IsProgram = ap.IsProgram,
                ProgramType = ap.ProgramType,
                IsProgramAddAble = ap.IsProgramAddAble,
                IsProgramEditAble = ap.IsProgramEditAble,
                IsProgramDeleteAble = ap.IsProgramDeleteAble,
                IsProgramViewAble = ap.IsProgramViewAble,
                IsProgramApprovalAble = ap.IsProgramApprovalAble,
                IsProgramUnApprovalAble = ap.IsProgramUnApprovalAble,
                IsProgramVoidAble = ap.IsProgramVoidAble,
                IsProgramUnVoidAble = ap.IsProgramUnVoidAble,
                IsProgramPrintAble = ap.IsProgramPrintAble,
                IsMenuAddVisible = ap.IsMenuAddVisible,
                IsMenuHomeVisible = ap.IsMenuHomeVisible,
                IsVisible = ap.IsVisible,
                IsProgramExportAble = ap.IsProgramExportAble,
                IsProgramCrossUnitAble = ap.IsProgramCrossUnitAble,
                IsProgramPowerUserAble = ap.IsProgramPowerUserAble
            };
        }

        public bool IsUserProgramAllow(string userId, string programId)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(programId))
                return false;

            var auQ = new EntitySpaces.Generated.AppUserQuery("auQ");
            var auugQ = new EntitySpaces.Generated.AppUserUserGroupQuery("auugQ");
            var augpQ = new EntitySpaces.Generated.AppUserGroupProgramQuery("augpQ");

            auQ.Select(auQ.UserID)
                .InnerJoin(auugQ).On(auugQ.UserID == auQ.UserID)
                .InnerJoin(augpQ).On(augpQ.UserGroupID == auugQ.UserGroupID && augpQ.ProgramID == programId)
                .Where(auQ.UserID == userId, auQ.ExpireDate.Date() > DateTime.Now, auQ.IsLocked == false);
            return auQ.LoadDataTable().Rows.Count > 0;
        }
    }
}
