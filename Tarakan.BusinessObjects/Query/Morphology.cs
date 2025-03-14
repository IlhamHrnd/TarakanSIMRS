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
            if (string.IsNullOrEmpty(morphologyId))
                return new MorphologyDto();

            var m = new EntitySpaces.Generated.Morphology();
            if (!m.LoadByPrimaryKey(morphologyId))
                return new MorphologyDto();

            return new MorphologyDto
            {
                MorphologyId = m.MorphologyID,
                DiagnoseId = m.MorphologyID,
                MorphologyName = m.MorphologyName
            };
        }
    }
}
