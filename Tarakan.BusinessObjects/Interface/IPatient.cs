using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IPatient
    {
        string GetPatientName(string patId);
        string PatientChronic(string patId);
        AppStandardReferenceItemDto PatientRisk(string riskStatus);
        string PatientAllergy(string patId);
        string PatientAddSchedule(string itemId, string scheduleType, int year, int month, DateTime from, DateTime to, string patId, string parId, string suId, string userId);
    }
}
