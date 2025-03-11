using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IVitalSign
    {
        DateTime LastVitalSignDate(string registrationNo, string fromRegistrationNo);
        List<VitalSignDto> VitalSignLastValue(string registrationNo, string fromRegistrationNo, bool isWithEwsLevel, DateTime lastDateTime);
    }
}
