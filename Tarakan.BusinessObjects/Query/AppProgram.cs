using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppProgram : BaseQuery, IAppProgram
    {
        public AppProgram(AppDbContext context) : base(context)
        {

        }

        public AppProgramDto LoadAppProgram(string programId)
        {
            if (string.IsNullOrWhiteSpace(programId))
                return new AppProgramDto
                {
                    ap = new EntityFramework.Models.AppProgram()
                };

            var query = (from ap in _context.AppPrograms
                         where ap.ProgramId == programId
                         select new { ap.ProgramId, ap.ProgramName, ap.IsProgram, ap.ProgramType, ap.IsProgramAddAble, ap.IsProgramEditAble,
                         ap.IsProgramDeleteAble, ap.IsProgramViewAble, ap.IsProgramApprovalAble, ap.IsProgramUnApprovalAble, ap.IsProgramVoidAble,
                         ap.IsProgramUnVoidAble, ap.IsProgramPrintAble, ap.IsMenuAddVisible, ap.IsMenuHomeVisible, ap.IsVisible, ap.IsProgramExportAble,
                         ap.IsProgramCrossUnitAble, ap.IsProgramPowerUserAble}).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.ProgramId))
                return new AppProgramDto
                {
                    ap = new EntityFramework.Models.AppProgram()
                };

            return new AppProgramDto
            {
                ap = new EntityFramework.Models.AppProgram
                {
                    ProgramId = query.ProgramId,
                    ProgramName = query.ProgramName,
                    IsProgram = query.IsProgram,
                    ProgramType = query.ProgramType ?? string.Empty,
                    IsProgramAddAble = query.IsProgramAddAble,
                    IsProgramEditAble = query.IsProgramEditAble,
                    IsProgramDeleteAble = query.IsProgramDeleteAble,
                    IsProgramViewAble = query.IsProgramViewAble,
                    IsProgramApprovalAble = query.IsProgramApprovalAble,
                    IsProgramUnApprovalAble = query.IsProgramUnApprovalAble,
                    IsProgramVoidAble = query.IsProgramVoidAble,
                    IsProgramUnVoidAble = query.IsProgramUnVoidAble,
                    IsProgramPrintAble = query.IsProgramPrintAble,
                    IsMenuAddVisible = query.IsMenuAddVisible,
                    IsMenuHomeVisible = query.IsMenuHomeVisible,
                    IsVisible = query.IsVisible,
                    IsProgramExportAble = query.IsProgramExportAble,
                    IsProgramCrossUnitAble = query.IsProgramCrossUnitAble,
                    IsProgramPowerUserAble = query.IsProgramPowerUserAble
                }
            };
        }

        public bool IsUserProgramAllow(string userId, string programId)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(programId))
                return false;

            var query = from au in _context.AppUsers
                        join auug in _context.AppUserUserGroups
                        on au.UserId equals auug.UserId
                        join augp in _context.AppUserGroupPrograms
                        on new { auug.UserGroupId, ProgramId = programId }
                        equals new { augp.UserGroupId, augp.ProgramId }
                        where au.UserId == userId && au.ExpireDate.Date > DateTime.Now && au.IsLocked == false
                        select new
                        {
                            au.UserId
                        };

            return query.Any();
        }
    }
}
