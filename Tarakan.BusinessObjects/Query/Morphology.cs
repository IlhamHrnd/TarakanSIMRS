using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Morphology : IMorphology
    {
        private readonly AppDbContext _context;

        public Morphology(AppDbContext context)
        {
            _context = context;
        }

        public MorphologyDto LoadByPrimarykey(string morphologyId)
        {
            if (string.IsNullOrWhiteSpace(morphologyId))
                return new MorphologyDto();

            var query = from m in _context.Morphologies
                        where m.MorphologyId == morphologyId
                        select m;

            if (!query.Any())
                return new MorphologyDto();

            var mor = new MorphologyDto();
            foreach (var item in query)
            {
                mor = new MorphologyDto
                {
                    MorphologyId = item.MorphologyId,
                    DiagnoseId = item.DiagnoseId,
                    MorphologyName = item.MorphologyName
                };
            }
            return mor;
        }
    }
}
