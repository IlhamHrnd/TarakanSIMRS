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
            var _patientRelateds = new List<string>();

            if (string.IsNullOrEmpty(patId))
                return _patientRelateds;

            var pr = new EntitySpaces.Generated.PatientRelated();
            pr.Query.Where(pr.Query.RelatedPatientID == patId);
            pr.Query.Top(1);
            if (pr.Query.Load() && !string.IsNullOrEmpty(pr.PatientID))
                _patientRelateds = [pr.PatientID];
            else
                _patientRelateds.Add(patId);

            var prColl = new EntitySpaces.Generated.PatientRelatedCollection();
            prColl.Query.Where(prColl.Query.PatientID == patId);
            if (prColl.Query.Load() && prColl.Count > 0)
            {
                foreach (var item in prColl)
                {
                    _patientRelateds.Add(item.PatientID);
                }
            }
            return _patientRelateds;
        }
    }
}
