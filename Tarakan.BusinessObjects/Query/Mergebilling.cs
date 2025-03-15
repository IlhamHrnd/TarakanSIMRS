using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Mergebilling : BaseQuery, IMergeBilling
    {
        public Mergebilling(AppDbContext context) : base(context)
        {
            
        }

        [Obsolete]
        public string PlafondProgress(string regNo, bool isModeText)
        {
            return EntitySpaces.Generated.MergeBilling.PlafondProgress(regNo, isModeText);
        }
    }
}
