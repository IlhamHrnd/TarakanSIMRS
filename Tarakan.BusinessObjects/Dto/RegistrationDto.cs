namespace Tarakan.BusinessObjects.Dto
{
    public class RegistrationDto
    {
        public string RegistrationDate { get; set; }
        public string ServiceUnitID { get; set; }
        public string ParamedicID { get; set; }
        public string ParamedicName { get; set; }
        public string RegistrationNo { get; set; }
        public string MedicalNo { get; set; }
        public string PatientID { get; set; }
        public bool IsConsul { get; set; }
        public string SRRegistrationType { get; set; }
        public string RoomID { get; set; }
        public string BedID { get; set; }
        public string SRBedStatus { get; set; }
        public string ReferFrom { get; set; }
        public string ReferFromRegistrationType { get; set; }
        public string ReferTo { get; set; }
        public string RegistrationTime { get; set; }
        public bool? IsConfirmedAttendance { get; set; }
        public bool IsNewPatient { get; set; }
        public string SRTriage { get; set; }
        public bool IsParamedicNotNull { get; set; }
        public bool IsNeedConfirmationOfAttendance { get; set; }
        public string FromRegistrationNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SalutationName { get; set; }
        public string RowSource { get; set; }
        public string SRCovidStatus { get; set; }
        public string SRPatientRiskStatus { get; set; }
        public string SRDischargeCondition { get; set; }
        public bool? IsDoctorOnDuty { get; set; }
        public bool IsFinishedAttendance { get; set; }
        public bool? IsAlreadyTransfer { get; set; }
        public string TransferNo { get; set; }
        public string Group { get; set; }
        public int? RegistrationQue { get; set; }
        public string ExternalQueNo { get; set; }

        #region Custom Variabel
        public int Count { get; set; }
        public int Sum { get; set; }
        public decimal Percentage { get; set; }
        public string IconCSS { get; set; }
        public string ColorCSS { get; set; }
        public string RoomName { get; set; }
        public string EmrDetailLink { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public string GuarantorName { get; set; }
        public bool? IsVipMember { get; set; }
        public string BpjsSepNo { get; set; }
        public string ServiceUnitName { get; set; }
        #endregion
    }
}
