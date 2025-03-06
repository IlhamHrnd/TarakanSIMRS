using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalyzer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int AnalyzerCategoryId { get; set; }

    public virtual PrescriptiveAnalyzerCategory AnalyzerCategory { get; set; }

    public virtual ICollection<PrescriptiveAnalysisDetail> PrescriptiveAnalysisDetails { get; set; } = new List<PrescriptiveAnalysisDetail>();
}
