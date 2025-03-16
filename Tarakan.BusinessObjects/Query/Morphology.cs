using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Morphology : BaseQuery, IMorphology
    {
        public Morphology(AppDbContext context) : base(context)
        {

        }

        public MorphologyDto LoadByPrimarykey(string morphologyId)
        {
            if (string.IsNullOrEmpty(morphologyId))
                return new MorphologyDto();

            var query = _context.Morphologies
                .Where(m => m.MorphologyId == morphologyId)
                .Select(m => new MorphologyDto
                {
                    MorphologyId = m.MorphologyId,
                    DiagnoseId = m.DiagnoseId ?? string.Empty,
                    MorphologyName = m.MorphologyName
                }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.MorphologyId))
                return new MorphologyDto();

            return new MorphologyDto
            {
                MorphologyId = query.MorphologyId,
                DiagnoseId = query.MorphologyId,
                MorphologyName = query.MorphologyName
            };
        }
    }
}
