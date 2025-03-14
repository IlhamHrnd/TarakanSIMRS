namespace Tarakan.BusinessObjects.Interface
{
    public interface IPatientTransferHistory
    {
        string? GetServiceUnitId(string regNo, DateTime dateTime);
    }
}
