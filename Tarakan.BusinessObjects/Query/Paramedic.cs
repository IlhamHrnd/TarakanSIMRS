using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Paramedic : IParamedic
    {
        private readonly AppDbContext _context;
        public Paramedic(AppDbContext context)
        {
            _context = context;
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
    }
}
