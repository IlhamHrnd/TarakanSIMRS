using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Paramedic : BaseQuery, IParamedic
    {
        private IAppParameter _appParameter;
        public Paramedic(AppDbContext context, IAppParameter appParameter) : base(context)
        {
            _appParameter = appParameter;
        }

        public string GetParamedicName(string parId)
        {
            if (string.IsNullOrWhiteSpace(parId))
                return string.Empty;

            var query = (from par in _context.Paramedics
                         where par.ParamedicId == parId
                         select par).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.ParamedicId))
                return string.Empty;

            return query.ParamedicName;
        }

        public Task<List<ParamedicDto>> GetParamedic(bool? isActive)
        {
            var query = _context.Paramedics.AsQueryable();

            if (isActive.HasValue)
                query = query.Where(par => par.IsActive == isActive.Value);

            return query.OrderBy(par => par.ParamedicName)
                .Select(par => new ParamedicDto
                {
                    ParamedicName = par.ParamedicName,
                    ParamedicID = par.ParamedicId
                }).ToListAsync();
        }

        public bool IsUserParamedicDpjp(string parId, string regNo, DateTime dateTime)
        {
            if (string.IsNullOrEmpty(parId) || string.IsNullOrEmpty(regNo))
                return false;

            var parTeam = _context.ParamedicTeams.AsQueryable()
                .Where(pt => pt.RegistrationNo == regNo && pt.ParamedicId == parId && pt.SrparamedicTeamStatus == _appParameter.ParameterString("ParamedicTeamStatusDpjpID")
                && (pt.EndDate == null || pt.EndDate >= dateTime)).ToList();

            if (parTeam.Count > 0)
                return true;

            var reg = _context.Registrations.AsQueryable()
                .Where(r => r.RegistrationNo == regNo && r.ParamedicId == parId).ToList();

            if (reg.Count > 0)
                return true;

            return false;
        }
    }
}
