using Tarakan.EntityFramework.Models;

namespace Tarakan.BusinessObjects.Dto
{
    public class TransPrescriptionItemDto
    {
        public TransPrescriptionItem tpi { get; set; }
        public string ItemName { get; set; }
        public string ItemUnit { get; set; }
        public string DosageUnit { get; set; }
        public string ConsumeMethod { get; set; }
    }
}
