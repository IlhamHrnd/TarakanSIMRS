using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class AppParameter : BaseQuery, IAppParameter
    {
        public AppParameter(AppDbContext context) : base(context)
        {

        }

        public string ParameterString(string parId)
        {
            if (string.IsNullOrEmpty(parId))
                return string.Empty;

            var ap = Parameter(parId);
            if (ap == null || ap.ap == null || string.IsNullOrEmpty(ap.ap.ParameterValue))
                return string.Empty;

            return ap.ap.ParameterValue;
        }

        public int ParameterInteger(string parId)
        {
            if (string.IsNullOrEmpty(parId))
                return 0;

            var ap = Parameter(parId);
            if (ap == null || string.IsNullOrEmpty(ap.ap.ParameterValue))
                return 0;

            try
            {
                return Converter.StringToInt(ap.ap.ParameterValue);
            }
            catch
            {
                return 0;
            }
        }

        public bool ParameterBoolean(string parId)
        {
            if (string.IsNullOrEmpty(parId))
                return false;

            var ap = Parameter(parId);
            if (ap == null || string.IsNullOrEmpty(ap.ap.ParameterValue))
                return false;

            return Converter.StringToBool(ap.ap.ParameterValue);
        }

        private AppParameterDto Parameter(string parId)
        {
            if (string.IsNullOrEmpty(parId))
                return new AppParameterDto();

            var query = (from ap in _context.AppParameters
                         where ap.ParameterId == parId
                         select new { ap.ParameterValue, ap.ParameterId, ap.ParameterName, ap.ParameterType }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.ParameterValue))
                return new AppParameterDto();

            return new AppParameterDto
            {
                ap = new EntityFramework.Models.AppParameter
                {
                    ParameterValue = query.ParameterValue,
                    ParameterId = query.ParameterId,
                    ParameterName = query.ParameterName,
                    ParameterType = query.ParameterType
                }
            };
        }
    }
}
