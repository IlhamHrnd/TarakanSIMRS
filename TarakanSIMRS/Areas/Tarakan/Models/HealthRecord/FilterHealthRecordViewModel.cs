using System.ComponentModel.DataAnnotations;
using Tarakan.BusinessObjects.Dto;

namespace TarakanSIMRS.Areas.Tarakan.Models.HealthRecord
{
    public class FilterHealthRecordViewModel
    {
        public List<ParamedicDto>? getParamedic { get; set; }
        public List<AppStandardReferenceItemDto>? getRegistrationType { get; set; }
        public List<ServiceUnitDto>? getServiceUnit { get; set; }
        public List<AppStandardReferenceItemDto>? getParamedicTeam { get; set; }
        public List<AppStandardReferenceItemDto>? getConfirmedAttendance { get; set; }

        #region Filter
        [DataType(DataType.Text)]
        public string RegistrationNo { get; set; }
        [DataType(DataType.Text)]
        public string ParamedicID { get; set; }
        [DataType(DataType.Text)]
        public string SRRegistrationType { get; set; }
        [DataType(DataType.Text)]
        public string ServiceUnitID { get; set; }
        [DataType(DataType.Text)]
        public string PatientName { get; set; }
        [DataType(DataType.Text)]
        public string SRParamedicTeam { get; set; }
        public bool IsIncludeClosed { get; set; }
        public bool IsIncludeDischarge { get; set; }
        public bool IsIncludeIPRSOAPInputted { get; set; }
        public bool IsIncludeNonIPRSOAPInputted { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime FromRegistrationTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime ToRegistrationTime { get; set; }
        [DataType(DataType.Text)]
        public string SRConfirmedAttend { get; set; }
        [DataType(DataType.Date)]
        public DateTime FromExamOrder { get; set; }
        [DataType(DataType.Date)]
        public DateTime ToExamOrder { get; set; }
        #endregion
    }
}
