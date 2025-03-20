using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;
using Tarakan.EntityFramework.Models;

namespace Tarakan.BusinessObjects.Query
{
    public class Patient : BaseQuery, IPatient
    {
        private readonly IAppStandardReferenceItem _appStandardReferenceItem;
        public Patient(AppDbContext context, IAppStandardReferenceItem appStandardReferenceItem) : base(context)
        {
            _appStandardReferenceItem = appStandardReferenceItem;
        }

        public string GetPatientName(string patId)
        {
            if (string.IsNullOrWhiteSpace(patId))
                return string.Empty;

            var pat = (from p in _context.Patients
                       where p.PatientId == patId
                       select new { p.FirstName, p.MiddleName, p.LastName, p.PatientId }).FirstOrDefault();

            if (pat == null || string.IsNullOrEmpty(pat.PatientId))
                return string.Empty;

            return Converter.GetFullName(pat.FirstName, pat.MiddleName, pat.LastName);

        }

        public string PatientChronic(string patId)
        {
            var query = (from ed in _context.EpisodeDiagnoses
                         join d in _context.Diagnoses
                             on ed.DiagnoseId equals d.DiagnoseId
                         join dt in _context.Dtds
                             on d.DtdNo equals dt.DtdNo
                         join asri in _context.AppStandardReferenceItems
                             on new { StandardReferenceId = "ChronicDisease", ItemId = dt.SrchronicDisease }
                             equals new { asri.StandardReferenceId, asri.ItemId }
                         join r in _context.Registrations
                             on ed.RegistrationNo equals r.RegistrationNo
                         where r.PatientId == patId && r.IsVoid == false && ed.IsVoid == false
                         select new { asri.ItemName }).Distinct().ToList();

            if (query.Count == 0)
                return string.Empty;

            string chronic = string.Empty;
            foreach (var item in query)
            {
                chronic = $"{chronic}, {item.ItemName}";
            }

            if (!string.IsNullOrEmpty(chronic))
                chronic = chronic[2..];

            return chronic;
        }

        public AppStandardReferenceItemDto PatientRisk(string riskStatus)
        {
            if (string.IsNullOrEmpty(riskStatus))
                return new AppStandardReferenceItemDto();

            var query = (from asri in _context.AppStandardReferenceItems
                         where asri.StandardReferenceId == "PatientRiskStatus" && asri.ItemId == riskStatus
                         select new { asri.ItemId, asri.StandardReferenceId, asri.ItemName }).FirstOrDefault();

            if (query == null || string.IsNullOrEmpty(query.ItemId))
                return new AppStandardReferenceItemDto();

            string color = query.ItemId switch
            {
                "0" => "green",
                "1" => "yellow",
                "2" => "red",
                _ => "skyblue",
            };

            return new AppStandardReferenceItemDto
            {
                StandardReferenceID = query.StandardReferenceId,
                ItemID = query.ItemId,
                ItemName = query.ItemName,
                ColorCSS = color
            };
        }

        public string PatientAllergy(string patId)
        {
            var pa = (from p in _context.PatientAllergies
                     where p.PatientId == patId
                     select new { p.AllergenName, p.DescAndReaction }).ToList();

            if (pa.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.AppendLine("<table style='width:100%'>");
            foreach (var item in pa)
            {
                sb.AppendLine("<tr>");
                sb.AppendFormat($"<td style='width:100px;font-weight: bold;'>{item.AllergenName}</td>");
                sb.AppendLine("<td style='width:5px'>:</td>");
                sb.AppendFormat($"<td style='color: red;'>{item.DescAndReaction}</td>");
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</table>");
            return sb.ToString();
        }

        public string PatientAddSchedule(string itemId, string scheduleType, int year, int month, DateTime from, DateTime to, string patId, string parId, string suId, string userId)
        {
            if (string.IsNullOrEmpty(itemId) || string.IsNullOrEmpty(scheduleType) || year == 0 || month == 0)
                return "Data is required";

            var asri = _appStandardReferenceItem.LoadByPrimaryKey("PatientScheduleName", itemId);
            if (asri == null || string.IsNullOrEmpty(asri.StandardReferenceID))
                return "Schedule not found";

            var dayOfWeek = asri != null && asri.NumericValue != 0 ? asri.NumericValue : -1;
            var dates = new List<DateTime>();
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.Date;

            switch (scheduleType)
            {
                case "year":
                    end = new DateTime(year, 12, 31);
                    break;

                case "month":
                    start = new DateTime(year, month, 1);
                    end = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                    break;

                case "day":
                    start = from;
                    end = to;
                    break;
            }

            for (DateTime? i = start.Date; i <= end.Date; i = i?.AddDays(1))
            {
                if (i?.DayOfWeek == (DayOfWeek)dayOfWeek)
                    dates.Add(i.Value.Date);
            }

            if (dates.Count == 0)
                return "Date not found";

            var msg = string.Empty;
            foreach (var date in dates)
            {
                try
                {
                    var ps = new PatientScheduling
                    {
                        PatientId = patId,
                        ServiceUnitId = suId,
                        ParamedicId = parId,
                        ScheduleDate = date,
                        Srschedule = itemId,
                        IsConfirmed = false,
                        LastUpdateByUserId = userId,
                        LastUpdateDateTime = DateTime.Now,
                    };
                    _context.PatientSchedulings.Add(ps);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    msg += e.Message;
                }
            }
            
            if (!string.IsNullOrEmpty(msg))
                return msg;
            else
                return "Success add schedule";
        }
    }
}
 