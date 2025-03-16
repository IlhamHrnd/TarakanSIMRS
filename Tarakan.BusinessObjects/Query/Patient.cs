using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Patient : BaseQuery, IPatient
    {
        public Patient(AppDbContext context) : base(context)
        {

        }

        public string GetPatientName(string patId)
        {
            if (string.IsNullOrWhiteSpace(patId))
                return string.Empty;

            var pat = _context.Patients
                .Where(p => p.PatientId == patId).FirstOrDefault();

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
                             on new { StandardReferenceId = "DiagnoseType", ItemId = dt.SrchronicDisease }
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
            var pa = _context.PatientAllergies.Where(p => p.PatientId == patId);

            if (!pa.Any())
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
    }
}
 