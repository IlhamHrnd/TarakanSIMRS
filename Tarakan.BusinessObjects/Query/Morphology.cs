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

            var query = (from m in _context.Morphologies
                         where m.MorphologyId == morphologyId
                         select new { m.MorphologyId, m.MorphologyName, m.DiagnoseId}).FirstOrDefault();
            
            if (query == null || string.IsNullOrEmpty(query.MorphologyId))
                return new MorphologyDto();

            return new MorphologyDto
            {
                MorphologyId = query.MorphologyId,
                DiagnoseId = query.DiagnoseId,
                MorphologyName = query.MorphologyName
            };
        }
    }
}
