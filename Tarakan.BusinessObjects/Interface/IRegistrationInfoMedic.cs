using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IRegistrationInfoMedic
    {
        List<RegistrationInfoMedicDto> IntegratedNotes(string regType, string regNo, List<string> regNoList, string patId, string filter);
    }
}
