using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class Patient : IPatient
    {
        public string GetPatientName(string patId)
        {
            if (string.IsNullOrWhiteSpace(patId))
                return string.Empty;

            var pat = new EntitySpaces.Generated.Patient();
            return !pat.LoadByPrimaryKey(patId) ? string.Empty : Converter.GetFullName(pat.FirstName, pat.MiddleName, pat.LastName);

        }
    }
}
