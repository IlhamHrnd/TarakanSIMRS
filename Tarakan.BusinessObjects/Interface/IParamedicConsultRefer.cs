using Tarakan.BusinessObjects.Dto;

namespace Tarakan.BusinessObjects.Interface
{
    public interface IParamedicConsultRefer
    {
        ParamedicConsultReferDto LoadByPrimaryKey(string refNo);
    }
}
