using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IDiagnose
    {
        DiagnoseDto LoadByPrimarykey(string diagId);
    }
}
