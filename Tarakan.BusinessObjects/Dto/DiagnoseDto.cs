namespace Tarakan.BusinessObjects.Dto
{
    public class DiagnoseDto
    {
        public string DiagnoseId { get; set; }

        public string DtdNo { get; set; }

        public string DiagnoseName { get; set; }

        public bool IsChronicDisease { get; set; }

        public bool IsDisease { get; set; }

        public bool IsActive { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public string LastUpdateByUserId { get; set; }
    }
}
