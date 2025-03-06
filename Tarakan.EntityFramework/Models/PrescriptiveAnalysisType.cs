using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysisType
{
    public int AnalysisTypeId { get; set; }

    public string AnalysisType { get; set; }

    public virtual ICollection<PrescriptiveAnalysis> PrescriptiveAnalyses { get; set; } = new List<PrescriptiveAnalysis>();
}
