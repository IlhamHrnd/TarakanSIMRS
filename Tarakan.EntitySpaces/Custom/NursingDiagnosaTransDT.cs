using System.Data;

namespace Tarakan.EntitySpaces.Generated
{
    public partial class NursingDiagnosaTransDT
    {
        public static string DetailEvaluationByEvaluationIdHtml(int evaluationId)
        {
            var nics = string.Empty;
            var xnic = DetailEvaluationByEvaluationID(evaluationId);
            string[] nicts = xnic.AsEnumerable().Select(row => row.Field<string>("SRNursingNicType")).Where(value => !string.IsNullOrEmpty(value)).Distinct().ToArray();
            string[] f1s = xnic.AsEnumerable().Select(row => row.Field<string>("F1")).Where(value => !string.IsNullOrEmpty(value)).Distinct().ToArray();
            string[] f2s = xnic.AsEnumerable().Select(row => row.Field<string>("F2")).Where(value => !string.IsNullOrEmpty(value)).Distinct().ToArray();

            foreach (var nict in nicts)
            {
                string sf3 = "";
                foreach (var f2 in f2s)
                {
                    string sf2 = "";
                    foreach (var f1 in f1s)
                    {
                        string sf1 = "";
                        foreach (var xn in xnic.AsEnumerable().Where(x => x.Field<string>("SRNursingNicType") == nict && x.Field<string>("F2") == f2 && x.Field<string>("F1") == f1))
                        {
                            sf1 += string.Format("<li class='linicnoc {2}'>{0}{1}</li>", xn.Field<string>("NursingDiagnosaName"),
                                (xn.Field<string>("SRNursingCarePlanning") == "03" ?
                                    string.Format("<img src=\"{0}\" />", "[BASEURL]/Images/Toolbar/new_tag_16.png") :
                                    (xn.Field<string>("SRNursingCarePlanning") == "01" ? string.Format("<img src=\"{0}\" />", "[BASEURL]/Images/Toolbar/stop_tag_16.png") : "")),
                                xn.Field<string>("SRNursingCarePlanning") == "01" ? ("linichide linichide" + evaluationId.ToString()) : "");
                        }
                        if (sf1.Length > 0)
                        {
                            sf1 = string.Format("<li class='linicnoc'>{0}<ul>{1}</ul></li>", f1, sf1);
                            sf2 += sf1;
                        }
                    }
                    if (sf2.Length > 0)
                    {
                        sf2 = string.Format("<li class='linicnoc'>{0}<ul>{1}</ul></li>", f2, sf2);
                        sf3 += sf2;
                    }
                }
                if (sf3.Length > 0)
                {
                    sf3 = string.Format("<li class='linicnoc'>{0}<ul>{1}</ul></li>", nict, sf3);
                    nics += sf3;
                }
            }
            if (nics.Length > 0)
            {
                nics = string.Format("<ul>{0}{1}</ul>", nics, nics.Contains("nichide") ?
                    string.Format("<li class='linicnoc linicshow linicshow{0}'><a href=\"javascript:void(0);\" onclick=\"EvalShowMoreClick('{0}');\">Show More...</li>", evaluationId) : "");
            }
            return nics;
        }

        private static DataTable DetailEvaluationByEvaluationID(int evaluationId)
        {
            var ndtQ = new NursingDiagnosaTransDTQuery("ndtQ");
            var ndQ = new NursingDiagnosaQuery("ndQ");
            var ndeQ = new NursingDiagnosaEvaluationQuery("ndeQ");
            var asriQ = new AppStandardReferenceItemQuery("asriQ");

            ndtQ.Select(ndQ.F1, ndQ.F2, asriQ.ItemName.As("SRNursingNicType"), ndeQ.SRNursingCarePlanning)
                .InnerJoin(ndQ).On(ndtQ.NursingDiagnosaID == ndtQ.NursingDiagnosaID)
                .InnerJoin(ndeQ).On(ndtQ.Id == ndeQ.InterventionID)
                .LeftJoin(asriQ).On(asriQ.StandardReferenceID == "SRNursingNicType" && ndQ.SRNursingNicType == asriQ.ItemID)
                .Where(ndeQ.EvaluationID == evaluationId);
            return ndtQ.LoadDataTable();
        }
    }
}
