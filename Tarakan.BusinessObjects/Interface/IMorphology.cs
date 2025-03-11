using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IMorphology
    {
        MorphologyDto LoadByPrimarykey(string morphologyId);
    }
}
