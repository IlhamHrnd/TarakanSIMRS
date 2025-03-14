using Tarakan.BusinessObjects.Dto;

namespace TarakanSIMRS.Areas.Tarakan.Models.Integrated
{
    public class IntegratedNoteViewModel
    {
        public List<RegistrationInfoMedicDto> getIntegratedNote { get; set; }
        public bool isUserParamedicDpjp { get; set; }
    }
}
