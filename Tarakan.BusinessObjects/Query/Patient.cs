using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Patient : IPatient
    {
        private readonly AppDbContext _context;

        public Patient(AppDbContext context)
        {
            _context = context;
        }

        public string GetPatientName(string patId)
        {
            if (string.IsNullOrWhiteSpace(patId))
                return string.Empty;

            var pat = new EntitySpaces.Generated.Patient();
            return !pat.LoadByPrimaryKey(patId) ? string.Empty : Converter.GetFullName(pat.FirstName, pat.MiddleName, pat.LastName);

        }

        public string PatientChronic(string patId)
        {
            var edQ = new EntitySpaces.Generated.EpisodeDiagnoseQuery("edQ");
            var dQ = new EntitySpaces.Generated.DiagnoseQuery("dQ");
            var dtQ = new EntitySpaces.Generated.DtdQuery("dtQ");
            var asriQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("asriQ");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");

            edQ.Select(asriQ.ItemName)
                .InnerJoin(dQ).On(dQ.DiagnoseID == edQ.DiagnoseID)
                .InnerJoin(dtQ).On(dtQ.DtdNo == dQ.DtdNo)
                .InnerJoin(asriQ).On(asriQ.StandardReferenceID == "ChronicDisease" && asriQ.ItemID == dtQ.SRChronicDisease)
                .InnerJoin(rQ).On(rQ.RegistrationNo == edQ.RegistrationNo)
                .Where(rQ.PatientID == patId, rQ.IsVoid == false, edQ.IsVoid == false)
                .Distinct();
            var dt = edQ.LoadDataTable();

            if (dt.Rows.Count == 0)
                return string.Empty;

            string chronic = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                chronic = $"{chronic}, {dr[0]}";
            }

            if (!string.IsNullOrEmpty(chronic))
                chronic = chronic.Substring(2);

            return chronic;
        }

        public AppStandardReferenceItemDto PatientRisk(string riskStatus)
        {
            if (string.IsNullOrEmpty(riskStatus))
                return new AppStandardReferenceItemDto();

            var asri = new EntitySpaces.Generated.AppStandardReferenceItem();
            if (!asri.LoadByPrimaryKey("PatientRiskStatus", riskStatus))
                return new AppStandardReferenceItemDto();

            string color = asri.ItemID switch
            {
                "0" => "green",
                "1" => "yellow",
                "2" => "red",
                _ => "skyblue",
            };

            return new AppStandardReferenceItemDto
            {
                StandardReferenceID = asri.StandardReferenceID,
                ItemID = asri.ItemID,
                ItemName = asri.ItemName,
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
