using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationInfoSumary : IRegistrationInfoSumary
    {
        public string RegistrationNoteCount(string regNo)
        {
            return EntitySpaces.Generated.RegistrationInfoSumary.RegistrationNoteCount(regNo);
        }
    }
}
