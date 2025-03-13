using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class ParamedicTeam : IParamedicTeam
    {
        private readonly AppDbContext _context;
        private readonly IParamedic _paramedic;
        private readonly IAppParameter _appParameter;
        public ParamedicTeam(AppDbContext context, IParamedic paramedic, IAppParameter appParameter)
        {
            _context = context;
            _paramedic = paramedic;
            _appParameter = appParameter;
        }

        public List<ParamedicTeamDto> GetParamedicTeam(string regNo)
        {
            if (string.IsNullOrEmpty(regNo))
                return [];

            var query = _context.ParamedicTeams
                .Where(pt => pt.RegistrationNo == regNo)
                .OrderBy(pt => pt.SrparamedicTeamStatus)
                .Select(pt => new ParamedicTeamDto
                {
                    ParamedicId = pt.ParamedicId,
                    SrparamedicTeamStatus = pt.SrparamedicTeamStatus,
                    StartDate = pt.StartDate,
                    EndDate = pt.EndDate
                }).ToList();

            if (query.Count == 0)
                return [];

            return query.AsEnumerable()
                .Select(item => new ParamedicTeamDto
                {
                    ParamedicId = item.ParamedicId,
                    ParamedicName = _paramedic.GetParamedicName(item.ParamedicId),
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    SrparamedicTeamStatus = item.SrparamedicTeamStatus
                })
                .ToList();
        }
    }
}
