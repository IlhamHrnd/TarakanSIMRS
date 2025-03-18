using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface ITransPrescription
    {
        List<TransPrescriptionDto> GetCurrentPrescription(List<string> regNos);
        List<TransPrescriptionItemDto> GetPrescriptionItem(string prescNo);
        List<TransPrescriptionDto> GetHistoryPrescription(List<string> regNos);
    }
}
