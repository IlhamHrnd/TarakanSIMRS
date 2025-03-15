using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationInfoSumary : BaseQuery, IRegistrationInfoSumary
    {
        public RegistrationInfoSumary(AppDbContext context) : base(context)
        {
            
        }
        public string RegistrationNoteCount(string regNo)
        {
            return EntitySpaces.Generated.RegistrationInfoSumary.RegistrationNoteCount(regNo);
        }
    }
}
