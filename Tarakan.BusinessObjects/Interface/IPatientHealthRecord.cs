namespace Tarakan.BusinessObjects.Interface
{
    public interface IPatientHealthRecord
    {
        bool LoadByTransactionNoRegNoOfTemplateEntry(string transNo, string regNo);
    }
}
