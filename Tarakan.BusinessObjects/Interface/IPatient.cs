using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IPatient
    {
        string GetPatientName(string patId);
        string PatientChronic(string patId);
        AppStandardReferenceItemDto PatientRisk(string riskStatus);
        string PatientAllergy(string patId);
    }
}
