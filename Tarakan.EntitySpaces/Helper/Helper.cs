using System.Globalization;

namespace Tarakan.EntitySpaces.Helper
{
    public static class Converter
    {
        public static decimal StringToDecimal(string input, decimal value = 0m)
        {
            if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
                return result;

            return value;
        }

        public static int StringToInt(string value)
        {
            try
            {
                if (int.TryParse(value, out int result))
                    return result;
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }

        public static bool StringToBool(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            if (value.Equals("true", StringComparison.CurrentCultureIgnoreCase) || value.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || value == "1")
                return true;

            return false;
        }
    }
}
