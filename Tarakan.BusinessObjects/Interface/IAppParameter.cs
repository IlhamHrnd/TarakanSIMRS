namespace Tarakan.BusinessObjects.Interface
{
    public interface IAppParameter
    {
        string ParameterString(string parameterId);
        int ParameterInteger(string parameterId);
        bool ParameterBoolean(string parameterId);
    }
}
