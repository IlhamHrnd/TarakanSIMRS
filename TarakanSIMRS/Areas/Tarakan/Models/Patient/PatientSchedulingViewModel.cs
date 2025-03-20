using Tarakan.BusinessObjects.Dto;

namespace TarakanSIMRS.Areas.Tarakan.Models.Patient
{
    public class PatientSchedulingViewModel
    {
        public List<AppStandardReferenceItemDto>? getScheduleName { get; set; }
        public List<AppStandardReferenceItemDto>? getScheduleType { get; set; }
        public List<AppStandardReferenceItemDto>? getYear { get; set; }
        public List<AppStandardReferenceItemDto>? getMonth { get; set; }
    }
}
