using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class Mergebilling : IMergeBilling
    {
        [Obsolete]
        public string PlafondProgress(string regNo, bool isModeText)
        {
            return EntitySpaces.Generated.MergeBilling.PlafondProgress(regNo, isModeText);
        }
    }
}
