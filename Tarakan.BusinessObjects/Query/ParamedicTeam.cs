using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class ParamedicTeam : BaseQuery, IParamedicTeam
    {
        private readonly IParamedic _paramedic;
        private readonly IAppParameter _appParameter;
        public ParamedicTeam(AppDbContext context, IParamedic paramedic, IAppParameter appParameter) : base(context)
        {
            _paramedic = paramedic;
            _appParameter = appParameter;
        }

        public List<ParamedicTeamDto> GetParamedicTeam(string regNo)
        {
            if (string.IsNullOrEmpty(regNo))
                return [];

            var query = (from par in _context.ParamedicTeams
                         where par.RegistrationNo == regNo
                         select new { par.ParamedicId , par.SrparamedicTeamStatus, par.StartDate, par.EndDate}).ToList();

            if (query.Count == 0)
                return [];

            return query
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
