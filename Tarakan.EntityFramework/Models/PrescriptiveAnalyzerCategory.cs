using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalyzerCategory
{
    public int Id { get; set; }

    public string Category { get; set; }

    public virtual ICollection<PrescriptiveAnalyzer> PrescriptiveAnalyzers { get; set; } = new List<PrescriptiveAnalyzer>();
}
