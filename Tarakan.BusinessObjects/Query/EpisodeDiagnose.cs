using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class EpisodeDiagnose : BaseQuery, IEpisodeDiagnose
    {
        private readonly IDiagnose _diagnose;
        private readonly IMorphology _morphology;
        public EpisodeDiagnose(AppDbContext context, IDiagnose diagnose, IMorphology morphology) : base(context)
        {
            _diagnose = diagnose;
            _morphology = morphology;
        }

        public string DiagnoseSummary(string regNo)
        {
            var query = from ed in _context.EpisodeDiagnoses
                        join asri in _context.AppStandardReferenceItems
                            on new { StandardReferenceId = "DiagnoseType", ItemId = ed.SrdiagnoseType }
                            equals new { asri.StandardReferenceId, asri.ItemId }
                        where ed.RegistrationNo == regNo
                        orderby asri.ItemName ascending, ed.CreateDateTime ascending
                        select new { DiagnoseType = asri.ItemName, ed.IsVoid, ed.DiagnoseId, ed.DiagnosisText, ed.ExternalCauseId, ed.MorphologyId };
            
            if (!query.Any())
                return string.Empty;

            var sb = new StringBuilder();
            sb.AppendLine("<div class=\"card\">");
            var diagnoseType = string.Empty;
            foreach (var item in query)
            {
                if (string.IsNullOrEmpty(diagnoseType) || !diagnoseType.Equals(item.DiagnoseType))
                    sb.AppendFormat($"<div class=\"card-header\">{item.DiagnoseType}</div>");

                sb.AppendLine("<div class=\"card-body\">");
                sb.AppendLine($"<div class=\"m-0\" style='{(item.IsVoid ? "text-decoration: line-through;" : string.Empty)}'>{item.DiagnoseId} {item.DiagnosisText}</div>");
                if (!string.IsNullOrEmpty(item.ExternalCauseId))
                {
                    var diag = _diagnose.LoadByPrimarykey(item.ExternalCauseId);
                    sb.AppendLine($"<div class=\"m-0\" style='{(item.IsVoid ? "text-decoration: line-through;" : string.Empty)}'>Ext Cause : {diag.DiagnoseId} {diag.DiagnoseName}</div>");
                }
                if (!string.IsNullOrEmpty(item.MorphologyId))
                {
                    var morp = _morphology.LoadByPrimarykey(item.MorphologyId);
                    sb.AppendLine($"<div class=\"m-0\" style='{(item.IsVoid ? "text-decoration: line-through;" : string.Empty)}'>Morphology : {morp.MorphologyId} {morp.MorphologyName}</div>");
                }
                sb.AppendLine("</div>");
            }
            return sb.ToString();
        }
    }
}
