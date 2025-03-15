using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysisDetail
{
    public int PrescriptiveAnalysisDetailsId { get; set; }

    public int AnalysisId { get; set; }

    public int AnalyzerId { get; set; }

    public int? Status { get; set; }

    public int? RecommendationCount { get; set; }

    public DateTime? RecordCreatedTimestamp { get; set; }

    public DateTime? RecordUpdateDateTimestamp { get; set; }

    public virtual PrescriptiveAnalysis Analysis { get; set; } = null!;

    public virtual PrescriptiveAnalyzer Analyzer { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalysisRecommendation> PrescriptiveAnalysisRecommendations { get; set; } = new List<PrescriptiveAnalysisRecommendation>();
}
