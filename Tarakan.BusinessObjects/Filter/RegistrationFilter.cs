namespace Tarakan.BusinessObjects.Filter
{
    public class RegistrationFilter
    {
        public string RegistrationNo { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PatientID { get; set; }
        public string SRRegistrationType { get; set; }
        public string ServiceUnitID { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int PageCurrent { get; set; }
        public string PatientName { get; set; }
        public bool IsIncludeDischarge { get; set; }
        public string FromRegistrationTime { get; set; }
        public string ToRegistrationTime { get; set; }
        public bool IsIncludeClosed { get; set; }
        public bool IsIncludeNonIPRSOAPInputted { get; set; }
        public bool IsIncludeIPRSOAPInputted { get; set; }
        public string ConfirmedAttendanceStatus { get; set; }
        public string Smf { get; set; }
        public string ParamedicID { get; set; }
        public string ParamedicTeam { get; set; }
        public DateTime? ExamOrderFromDate { get; set; }
        public DateTime? ExamOrderToDate { get; set; }
    }
}
