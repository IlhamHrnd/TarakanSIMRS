namespace Tarakan.BusinessObjects.Interface
{
    public interface IVitalSign
    {
        DateTime LastVitalSignDate(string registrationNo, string fromRegistrationNo);
    }
}
