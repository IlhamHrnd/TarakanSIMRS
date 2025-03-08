using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class AppParameter : IAppParameter
    {
        public string ParameterString(string parameterId)
        {
            if (string.IsNullOrEmpty(parameterId))
                return string.Empty;

            var ap = new EntitySpaces.Generated.AppParameter();
            if (!ap.LoadByPrimaryKey(parameterId))
                return string.Empty;

            return ap.ParameterValue;
        }

        public int ParameterInteger(string parameterId)
        {
            if (string.IsNullOrEmpty(parameterId))
                return 0;

            var ap = new EntitySpaces.Generated.AppParameter();
            if (!ap.LoadByPrimaryKey(parameterId))
                return 0;

            try
            {
                return Converter.StringToInt(ap.ParameterValue);
            }
            catch
            {
                return 0;
            }
        }

        public bool ParameterBoolean(string parameterId)
        {
            if (string.IsNullOrEmpty(parameterId))
                return false;

            var ap = new EntitySpaces.Generated.AppParameter();
            if (!ap.LoadByPrimaryKey(parameterId))
                return false;

            return Converter.StringToBool(ap.ParameterValue);
        }
    }
}
