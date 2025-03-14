namespace Tarakan.BusinessObjects.Dto
{
    public class ParamedicConsultReferDto
    {
        public string ConsultReferNo { get; set; }

        public DateTime ConsultDateTime { get; set; }

        public string RegistrationNo { get; set; }

        public string ParamedicId { get; set; }

        public string SrparamedicConsultType { get; set; }

        public string ConsultReferType { get; set; }

        public string ToServiceUnitId { get; set; }

        public string ToParamedicId { get; set; }

        public string ToRoomId { get; set; }

        public int? ToRegistrationQue { get; set; }

        public string ChiefComplaint { get; set; }

        public string PastMedicalHistory { get; set; }

        public string Hpi { get; set; }

        public string ActionExamTreatment { get; set; }

        public string ActiveMotion { get; set; }

        public string PassiveMotion { get; set; }

        public string Notes { get; set; }

        public DateTime? AnswerDateTime { get; set; }

        public string Answer { get; set; }

        public string AnswerDiagnose { get; set; }

        public string AnswerPlan { get; set; }

        public string AnswerAction { get; set; }

        public string ToRegistrationNo { get; set; }

        public string ToAppointmentNo { get; set; }

        public bool? IsPhysiotherapy { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public string LastUpdateByUserId { get; set; }

        public string PatientId { get; set; }

        public string SrconsultAnswerType { get; set; }

        public bool? IsVoid { get; set; }

        public DateTime? CreateDateTime { get; set; }

        public string CreateByUserId { get; set; }

        public byte[] PhysicianSign { get; set; }

        public byte[] PhysicianAnswerSign { get; set; }
    }
}
