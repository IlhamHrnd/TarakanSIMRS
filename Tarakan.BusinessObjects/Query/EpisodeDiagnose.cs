using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class EpisodeDiagnose : IEpisodeDiagnose
    {
        private readonly AppDbContext _context;
        private readonly IDiagnose _diagnose;
        private readonly IMorphology _morphology;
        public EpisodeDiagnose(AppDbContext context, IDiagnose diagnose, IMorphology morphology)
        {
            _context = context;
            _diagnose = diagnose;
            _morphology = morphology;
        }

        public string DiagnoseSummary(string regNo)
        {
            var edQ = new EntitySpaces.Generated.EpisodeDiagnoseQuery("edQ");
            var asriQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("asriQ");

            edQ.Select(edQ, asriQ.ItemName.As("DiagnoseType"))
                .InnerJoin(asriQ).On(asriQ.StandardReferenceID == "DiagnoseType" && asriQ.ItemID == edQ.SRDiagnoseType)
                .Where(edQ.RegistrationNo == regNo)
                .OrderBy(asriQ.ItemName.Ascending, edQ.CreateDateTime.Ascending);
            var dt = edQ.LoadDataTable();
            if (dt.Rows.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();
            sb.AppendLine("<div class=\"card\">");
            var diagnoseType = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                if (string.IsNullOrEmpty(diagnoseType) || !diagnoseType.Equals(dr["DiagnoseType"]))
                    sb.AppendFormat($"<div class=\"card-header\">{dr["DiagnoseType"]}</div>");

                sb.AppendLine("<div class=\"card-body\">");
                sb.AppendLine($"<div class=\"m-0\" style='{(true.Equals(dr["IsVoid"]) ? "text-decoration: line-through;" : string.Empty)}'>{dr["DiagnoseID"]} {dr["DiagnosisText"]}</div>");
                var externalCauseID = Convert.ToString(dr["ExternalCauseID"]);
                if (!string.IsNullOrEmpty(externalCauseID))
                {
                    var diag = _diagnose.LoadByPrimarykey(externalCauseID);
                    sb.AppendLine($"<div class=\"m-0\" style='{(true.Equals(dr["IsVoid"]) ? "text-decoration: line-through;" : string.Empty)}'>Ext Cause : {diag.DiagnoseId} {diag.DiagnoseName}</div>");
                }
                var morphologyID = Convert.ToString(dr["MorphologyID"]);
                if (!string.IsNullOrEmpty(morphologyID))
                {
                    var morp = _morphology.LoadByPrimarykey(morphologyID);
                    sb.AppendLine($"<div class=\"m-0\" style='{(true.Equals(dr["IsVoid"]) ? "text-decoration: line-through;" : string.Empty)}'>Morphology : {morp.MorphologyId} {morp.MorphologyName}</div>");
                }
                sb.AppendLine("</div>");
            }
            sb.AppendLine("</div>");
            return sb.ToString();
        }
    }
}
