using EntitySpaces.Interfaces;
using System.Security.Cryptography;
using Inter = EntitySpaces.Loader;

namespace Tarakan.BusinessObjects.Helper
{
    public class Helper
    {
        public static void initES(string connection)
        {
            esProviderFactory.Factory = new Inter.esDataProviderFactory();
            esConnectionElement conn = new esConnectionElement();
            conn.DatabaseVersion = "2012";
            conn.ConnectionString = connection;
            esConfigSettings.ConnectionInfo.Connections.Add(conn);
        }
    }

    public static class Converter
    {
        public static int GetAgeInYear(DateTime dateTime)
        {
            return GetAge(dateTime, DateTime.Today, 0);
        }

        public static int GetAgeInMonth(DateTime dateTime)
        {
            return GetAge(dateTime, DateTime.Today, 1);
        }

        public static int GetAgeInDay(DateTime dateTime)
        {
            return GetAge(dateTime, DateTime.Today, 2);
        }

        private static int GetAge(DateTime fromDate, DateTime toDate, int ageType)
        {
            var birthDayThisYear = new DateTime();

            int months, days;

            if (!DateTime.TryParse(fromDate.Month + "/" + fromDate.Day + "/" + toDate.Year, out birthDayThisYear))
            {
                birthDayThisYear = new DateTime(toDate.Year, fromDate.AddMonths(1).Month, 1);
                months = toDate.Month - fromDate.AddMonths(1).Month;
                days = toDate.Day - 1;
            }
            else
            {
                months = toDate.Month - fromDate.Month;
                days = toDate.Day - fromDate.Day;
            }

            var years = toDate.Year - fromDate.Year;

            if (birthDayThisYear > toDate)
            {
                years -= 1;
                months += 12;
            }

            if (birthDayThisYear.Day > toDate.Day)
            {
                months -= 1;
                var day = birthDayThisYear.Day;
                DateTime dt;

                if (DateTime.IsLeapYear(birthDayThisYear.Year))
                {
                    if ((toDate.Month - 1) == 2 && birthDayThisYear.Day > 29)
                        day = 29;
                }
                else
                {
                    if ((toDate.Month - 1) == 2 && birthDayThisYear.Day > 28)
                        day = 28;
                }

                try
                {
                    dt = new DateTime((toDate.Month - 1 <= 0 ? birthDayThisYear.Year - 1 : birthDayThisYear.Year), (toDate.Month - 1 <= 0 ? 12 : toDate.Month - 1), day);
                }
                catch
                {
                    dt = new DateTime((toDate.Month - 1 <= 0 ? birthDayThisYear.Year - 1 : birthDayThisYear.Year), (toDate.Month - 1 <= 0 ? 1 : toDate.Month - 1), day - 1);
                }

                var ts = toDate - dt;
                days = ts.Days;
            }

            return ageType switch
            {
                0 => years,
                1 => months,
                _ => days,
            };
        }

        public static string GetFullName(string firstName, string middleName, string lastName)
        {
            middleName = string.IsNullOrWhiteSpace(middleName) ? "" : middleName;
            lastName = string.IsNullOrWhiteSpace(lastName) ? "" : lastName;

            return $"{firstName} {middleName} {lastName}".Trim();
        }
    }

    public static class Const
    {
        #region Date Format
        private static string shortyearpattern = "yyMMdd";
        private static string longyearpattern = "yyyy-MM-dd HH:mm:ss";
        private static string yearmonthdate = "yyyy-MM-dd";
        private static string date = "dd/MM/yyyy";
        private static string datetime = "dd/MM/yyyy HH:mm";
        private static string datetimesecond = "dd/MM/yyyy HH:mm:ss";
        private static string datelong = "dd MMM yyyy";
        private static string dateshortmonth = "dd-MMM-yyyy";
        private static string longdatepattern = "dd-MMM-yyyy HH:mm:ss";
        private static string datehourminute = "dd/MM/yyyy HH:mm";
        private static string dateshortmonthhourminute = "dd-MMM-yyyy HH:mm";
        private static string hourmin = "HH:mm";
        private static string month = "MMMM";
        private static string daydatemonthyear = "dddd, dd MMMM yyyy";

        public static string Shortyearpattern { get => shortyearpattern; set => shortyearpattern = value; }
        public static string Longyearpattern { get => longyearpattern; set => longyearpattern = value; }
        public static string Date { get => date; set => date = value; }
        public static string Datetime { get => datetime; set => datetime = value; }
        public static string Datetimesecond { get => datetimesecond; set => datetimesecond = value; }
        public static string Datelong { get => datelong; set => datelong = value; }
        public static string Dateshortmonth { get => dateshortmonth; set => dateshortmonth = value; }
        public static string Longdatepattern { get => longdatepattern; set => longdatepattern = value; }
        public static string Datehourminute { get => datehourminute; set => datehourminute = value; }
        public static string Dateshortmonthhourminute { get => dateshortmonthhourminute; set => dateshortmonthhourminute = value; }
        public static string Hourmin { get => hourmin; set => hourmin = value; }
        public static string Month { get => month; set => month = value; }
        public static string Yearmonthdate { get => yearmonthdate; set => yearmonthdate = value; }
        public static string Daydatemonthyear { get => daydatemonthyear; set => daydatemonthyear = value; }
        #endregion

        #region Registration Type
        private static string outpatient = "OPR";
        private static string inpatient = "IPR";
        private static string medicalcheckup = "MCU";
        private static string emergency = "EMR";

        public static string Outpatient { get => outpatient; set => outpatient = value; }
        public static string Inpatient { get => inpatient; set => inpatient = value; }
        public static string Medicalcheckup { get => medicalcheckup; set => medicalcheckup = value; }
        public static string Emergency { get => emergency; set => emergency = value; }
        #endregion

        #region User Type
        private static string administration = "ADM";
        private static string doctor = "DTR";
        private static string nurse = "NRS";
        private static string nutrition = "NUT";
        private static string physiotherapy = "PHY";
        private static string pharmacy = "FAR";
        private static string rehabilitation = "RHB";
        private static string registration = "REG";
        private static string labanalyst = "AL";

        public static string Administration { get => administration; set => administration = value; }
        public static string Doctor { get => doctor; set => doctor = value; }
        public static string Nurse { get => nurse; set => nurse = value; }
        public static string Nutrition { get => nutrition; set => nutrition = value; }
        public static string Physiotherapy { get => physiotherapy; set => physiotherapy = value; }
        public static string Pharmacy { get => pharmacy; set => pharmacy = value; }
        public static string Rehabilitation { get => rehabilitation; set => rehabilitation = value; }
        public static string Registration { get => registration; set => registration = value; }
        public static string LabAnalyst { get => labanalyst; set => labanalyst = value; }
        #endregion

        #region Bridging
        private static string bpjs = "BridgingType-001";
        private static string inacbg = "BridgingType-002";
        private static string inhealth = "BridgingType-003";
        private static string bpjstnipolripns = "BridgingType-004";
        private static string bpjspasienumum = "BridgingType-005";
        private static string linklis = "BridgingType-006";
        private static string antrol = "BridgingType-007";

        public static string Bpjs { get => bpjs; set => bpjs = value; }
        public static string Inacbg { get => inacbg; set => inacbg = value; }
        public static string Inhealth { get => inhealth; set => inhealth = value; }
        public static string Bpjstnipolripns { get => bpjstnipolripns; set => bpjstnipolripns = value; }
        public static string Bpjspasienumum { get => bpjspasienumum; set => bpjspasienumum = value; }
        public static string Linklis { get => linklis; set => linklis = value; }
        public static string Antrol { get => antrol; set => antrol = value; }
        #endregion

        #region Guarantor
        private static string self = "SELF";

        public static string Self { get => self; set => self = value; }
        #endregion
    }

    public static class SecureTarakan
    {
        public static string Encrypt(string data, string key1, string key2)
        {
            var ms = new MemoryStream();

            var objKey = new DESCryptoServiceProvider { Key = objLockKey(key1), IV = objLockKey(key2) };

            var encStream = new CryptoStream(ms,
            objKey.CreateEncryptor(), CryptoStreamMode.Write);
            var sw = new StreamWriter(encStream);
            sw.WriteLine(data);
            sw.Close();
            encStream.Close();

            var bytData = ms.ToArray();
            var strReturnData = bytData.Aggregate("", (current, bytChar) => current + bytChar.ToString().PadLeft(3, Convert.ToChar("0")));

            ms.Close();

            return strReturnData;
        }

        public static string Decrypt(string data, string key1, string key2)
        {
            var bytData = new byte[data.Length / 3];
            for (int i = 0; i < data.Length; i += 3)
            {
                bytData[i / 3] = byte.Parse(data.Substring(i, 3));
            }

            var ms = new MemoryStream(bytData);
            var objKey = new DESCryptoServiceProvider { Key = objLockKey(key1), IV = objLockKey(key2) };
            var encStream = new CryptoStream(ms, objKey.CreateDecryptor(), CryptoStreamMode.Read);
            var sr = new StreamReader(encStream);

            var strReturnData = sr.ReadLine();

            sr.Close();
            encStream.Close();
            ms.Close();

            return strReturnData;
        }

        private static byte[] objLockKey(string strPassword)
        {
            const int intKeyLength = 8;
            strPassword = strPassword.PadRight(intKeyLength,
            Convert.ToChar(".")).Substring(0, intKeyLength);
            var objKey = new byte[strPassword.Length];
            for (var intCount = 0; intCount < strPassword.Length; intCount++)
            {
                objKey[intCount] = Convert.ToByte(Convert.ToChar(strPassword.Substring(intCount, 1)));
            }
            return objKey;
        }
    }
}
