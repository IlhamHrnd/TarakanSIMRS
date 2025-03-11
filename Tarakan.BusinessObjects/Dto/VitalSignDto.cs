namespace Tarakan.BusinessObjects.Dto
{
    public class VitalSignDto
    {
        public string SRAnswerType { get; set; }
        public string VitalSignID { get; set; }
        public string VitalSignName { get; set; }
        public string QuestionAnswerPrefix { get; set; }
        public string QuestionAnswerSuffix { get; set; }
        public string QuestionAnswerText { get; set; }
        public int QuestionAnswerNum { get; set; }
        public string QuestionAnswerText2 { get; set; }
        public string RecordDate { get; set; }
        public string RecordTime { get; set; }
        public string VitalSignInitial { get; set; }
        public string EwsLevelColor { get; set; }
        public string QuestionAnswerFormatted { get; set; }
    }
}
