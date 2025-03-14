using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Paramedic : IParamedic
    {
        private readonly AppDbContext _context;
        private IAppParameter _appParameter;
        public Paramedic(AppDbContext context, IAppParameter appParameter)
        {
            _context = context;
            _appParameter = appParameter;
        }

        public string GetParamedicName(string paramedicID)
        {
            if (string.IsNullOrWhiteSpace(paramedicID))
                return string.Empty;

            var pa = new EntitySpaces.Generated.Paramedic();
            return pa.LoadByPrimaryKey(paramedicID) ? pa.ParamedicName : string.Empty;
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
                && (pt.EndDate == null || pt.EndDate >= dateTime)).FirstOrDefault();

            if (parTeam == null || string.IsNullOrEmpty(parTeam.ParamedicId))
                return false;

            var reg = _context.Registrations.AsQueryable()
                .Where(r => r.RegistrationNo == regNo && r.ParamedicId == parId).FirstOrDefault();

            if (reg == null || string.IsNullOrEmpty(reg.RegistrationNo))
                return false;

            return true;
        }
    }
}
