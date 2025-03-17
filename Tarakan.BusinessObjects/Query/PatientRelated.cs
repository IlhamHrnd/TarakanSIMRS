using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class PatientRelated : BaseQuery, IPatientRelated
    {
        public PatientRelated(AppDbContext context) : base(context)
        {

        }

        public List<string> PatientRelateds(string patId)
        {
            if (string.IsNullOrWhiteSpace(patId))
                return [];

            var _patientRelateds = new List<string>();
            var pr = (from p in _context.PatientRelateds
                      where p.RelatedPatientId == patId
                      select new { p.PatientId }).FirstOrDefault();

            _patientRelateds = pr != null && !string.IsNullOrEmpty(pr.PatientId) ? ([pr.PatientId]) : ([patId]);
            var coll = (from p in _context.PatientRelateds
                        where p.PatientId == patId
                        select new { p.PatientId }).ToList();

            if (coll == null || coll.Count == 0)
                return _patientRelateds;

            foreach (var p in coll)
            {
                _patientRelateds.Add(p.PatientId);
            }
            return _patientRelateds;
        }
    }
}
