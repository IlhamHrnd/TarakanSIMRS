using System.Data;
using Tarakan.EntitySpaces.Helper;

namespace Tarakan.EntitySpaces.Generated
{
    public partial class VitalSign
    {
        [Obsolete]
        public static string EwsScore(string regNo, string fromRegNo, string regType, string patID,
            DateTime dob)
        {
            if (!regType.Equals("IPR"))
                return string.Empty;

            // EWS for InPatient
            string ewsTopLevelVitalSignValue = string.Empty;
            string ewsTopLevelColor = string.Empty;
            DateTime vitalSignRecordDate = DateTime.Today;
            var topEwsLevel = VitalSign.EwsLevelTopLevel(regNo, fromRegNo, dob,
                ref ewsTopLevelVitalSignValue, ref ewsTopLevelColor, ref vitalSignRecordDate, DateTime.Now);

            return topEwsLevel > 0
                ? $"<div style='background-color: {ewsTopLevelColor};width:100%;padding-left: 2px'><a href=\"#\" onclick=\"javascript:openVitalSignChartEws('{patID}','{regNo}','{fromRegNo}','{vitalSignRecordDate}'); return false;\">{ewsTopLevelVitalSignValue}</a></div>"
                : string.Empty;
        }

        [Obsolete]
        public static DataTable VitalSignLastValue(string registrationNo, string fromRegistrationNo, bool isWithEwsLevel, DateTime lastDateTime)
        {
            var dtb = LastVitalSignRecord(registrationNo, fromRegistrationNo, lastDateTime);
            var dt = DistinctAndSetEws(registrationNo, isWithEwsLevel, dtb);
            return dt;
        }

        [Obsolete]
        private static DataTable LastVitalSignRecord(string regNo, string fromRegNo, DateTime dateTime)
        {
            var phrlQ = new PatientHealthRecordLineQuery("phrlQ");
            var qQ = new QuestionQuery("qQ");
            var vsQ = new VitalSignQuery("vsQ");
            var phrQ = new PatientHealthRecordQuery("phrQ");

            phrlQ.InnerJoin(qQ).On(phrlQ.QuestionID == qQ.QuestionID)
                .InnerJoin(vsQ).On(qQ.VitalSignID == vsQ.VitalSignID)
                .InnerJoin(phrQ).On(phrlQ.TransactionNo == phrQ.TransactionNo && phrlQ.RegistrationNo == phrQ.RegistrationNo);

            if (!string.IsNullOrEmpty(fromRegNo))
                phrlQ.Where(phrlQ.Or(phrlQ.RegistrationNo == regNo, phrlQ.RegistrationNo == fromRegNo));
            else
                phrlQ.Where(phrlQ.RegistrationNo == regNo);

            phrlQ.Where(phrQ.Or(phrQ.RecordDate <= dateTime, phrQ.RecordDate <= dateTime.Date.AddDays(-1), phrQ.And(phrQ.RecordDate == dateTime.Date, phrQ.RecordTime <= dateTime.ToString("HH:mm"))))
                .Select(qQ.SRAnswerType, vsQ.VitalSignID, vsQ.VitalSignName, phrlQ.QuestionAnswerPrefix, phrlQ.QuestionAnswerSuffix, phrlQ.QuestionAnswerText, phrlQ.QuestionAnswerNum, phrlQ.QuestionAnswerText2,
                phrQ.RecordDate, phrQ.RecordTime, vsQ.VitalSignInitial)
                .OrderBy(vsQ.SRVitalSignGroup.Ascending, vsQ.RowIndexInGroup.Ascending, vsQ.VitalSignName.Ascending, phrQ.RecordDate.Descending, phrlQ.TransactionNo.Descending);

            var dtb = phrlQ.LoadDataTable();
            return dtb;
        }

        [Obsolete]
        private static int EwsLevelTopLevel(string registrationNo, string referFromRegistrationNo, DateTime dateOfBirth, ref string ewsTopLevelVitalSignValue, ref string ewsTopLevelColor, ref DateTime recordDate, DateTime lastDateTime)
        {
            var dtb = LastVitalSignRecord(registrationNo, referFromRegistrationNo, lastDateTime);

            // Ambil yg terakhir dan ada isinya
            var dtbSelected = dtb.Clone();
            var id = string.Empty;
            foreach (DataRow row in dtb.Rows)
            {
                if (!id.Equals(row["VitalSignID"]) && (!string.IsNullOrEmpty(row["QuestionAnswerText"].ToString()) || Convert.ToDecimal(row["QuestionAnswerNum"]) != 0))
                {
                    id = row["VitalSignID"].ToString();
                    dtbSelected.Rows.Add(row.ItemArray);
                }
            }

            var topEwsLevel = 0;
            if (dtbSelected.Rows.Count > 0)
            {
                foreach (DataRow row in dtbSelected.Rows)
                {
                    var nextEwsLevel = EwsLevelValue(row["VitalSignID"] != DBNull.Value ? (string)row["VitalSignID"] : string.Empty, dateOfBirth, row["RecordDate"] != DBNull.Value ? Convert.ToDateTime(row["RecordDate"]) : new DateTime(), row["QuestionAnswerNum"] != DBNull.Value ? Convert.ToDecimal(row["QuestionAnswerNum"]) : 0);
                    if (topEwsLevel < nextEwsLevel)
                    {
                        topEwsLevel = nextEwsLevel;
                        ewsTopLevelVitalSignValue = string.Format("{0}: {1}", row["VitalSignInitial"], VitalSignValueFormated(row));
                        ewsTopLevelColor = EwsLevelColor(topEwsLevel);
                        recordDate = Convert.ToDateTime(row["RecordDate"]);
                    }

                }
            }

            return topEwsLevel;
        }

        private static int EwsLevelValue(string vitalSignID, DateTime birthDate, DateTime vitalSignDate, decimal vitalSignValue)
        {
            int ageInDay = (vitalSignDate - birthDate).Days;
            var qr = new VitalSignEwsLevelQuery("vselQ");
            qr.Where(qr.StartAgeInDay <= ageInDay, qr.StartValue <= vitalSignValue, qr.VitalSignID == vitalSignID)
                .Top(1)
                .OrderBy(qr.StartAgeInDay.Descending, qr.StartValue.Descending);

            var ewsLevel = new VitalSignEwsLevel();
            if (ewsLevel.Load(qr))
                return ewsLevel.EwsLevel ?? 0;
            return 0;
        }

        private static string EwsLevelColor(int level)
        {
            return level switch
            {
                1 => "lightblue",
                2 => "yellow",
                3 => "Coral",
                _ => "white",
            };
        }

        public static string EwsLevelColor(string vitalSignID, DateTime birthDate, DateTime vitalSignDate, decimal vitalSignValue)
        {
            var level = EwsLevelValue(vitalSignID, birthDate, vitalSignDate, vitalSignValue);
            return EwsLevelColor(level);
        }

        private static string VitalSignValueFormated(DataRow row)
        {
            var answerText = row["QuestionAnswerText"].ToString();
            string questionAnswerFormatted;
            switch (row["SRAnswerType"].ToString())
            {
                case "CNM":
                    try
                    {
                        answerText = answerText.Split('|')[1];
                    }
                    catch
                    {
                    }


                    questionAnswerFormatted = string.Format("{0} {1}", answerText,
                        string.IsNullOrEmpty(row["QuestionAnswerSuffix"].ToString())
                            ? string.Empty
                            : row["QuestionAnswerSuffix"].ToString()
                    );
                    break;
                default:
                    questionAnswerFormatted = string.Format("{0} {1}",
                        string.IsNullOrEmpty(answerText)
                            ? Converter.RemoveZeroDigits(Convert.ToDecimal(row["QuestionAnswerNum"] == DBNull.Value
                                ? -1
                                : row["QuestionAnswerNum"]))
                            : (row["QuestionAnswerText"].ToString()),
                        string.IsNullOrEmpty(row["QuestionAnswerSuffix"].ToString())
                            ? string.Empty
                            : row["QuestionAnswerSuffix"].ToString()
                    );
                    break;
            }

            return questionAnswerFormatted;
        }

        private static DataTable DistinctAndSetEws(string registrationNo, bool isWithEwsLevel, DataTable dtb)
        {
            var dt = dtb.Clone();
            var id = string.Empty;
            foreach (DataRow row in dtb.Rows)
            {
                if (!id.Equals(row["VitalSignID"]) && (!string.IsNullOrEmpty(row["QuestionAnswerText"].ToString()) ||
                                                       Convert.ToDecimal(row["QuestionAnswerNum"]) != 0))
                {
                    id = row["VitalSignID"].ToString();
                    //Copy
                    dt.Rows.Add(row.ItemArray);
                }
            }

            // EWS & Formated
            var dateOfBirth = DateTime.Today;
            if (isWithEwsLevel)
            {
                var reg = new Registration();
                reg.LoadByPrimaryKey(registrationNo);

                var pat = new Patient();
                pat.LoadByPrimaryKey(reg.PatientID);
                dateOfBirth = pat.DateOfBirth ?? DateTime.Today;
            }

            dt.Columns.Add("EwsLevelColor", typeof(string));
            dt.Columns.Add("QuestionAnswerFormatted", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                // EWS Level Color
                string ewsLevel = "white";
                if (isWithEwsLevel && Convert.ToDecimal(dr["QuestionAnswerNum"]) != 0)
                    dr["EwsLevelColor"] = VitalSign.EwsLevelColor(dr["VitalSignID"].ToString(), dateOfBirth, Convert.ToDateTime(dr["RecordDate"]), Convert.ToDecimal(dr["QuestionAnswerNum"]));

                dr["QuestionAnswerFormatted"] = VitalSignValueFormated(dr);
            }
            dt.AcceptChanges();
            return dt;
        }
    }
}
