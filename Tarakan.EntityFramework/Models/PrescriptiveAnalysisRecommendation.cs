using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysisRecommendation
{
    public int Id { get; set; }

    public string RecommendationId { get; set; }

    public double? ComputedRankFactor { get; set; }

    public int? PrescriptiveAnalysisDetailsId { get; set; }

    public bool? IsFlagged { get; set; }

    public int OptimizationStatusId { get; set; }

    public string OptimizationErrorMessage { get; set; }

    public virtual PrescriptiveOptimiztionExecutionStatus OptimizationStatus { get; set; }

    public virtual PrescriptiveAnalysisDetail PrescriptiveAnalysisDetails { get; set; }

    public virtual ICollection<PrescriptiveAnalysisRecommendationProperty> PrescriptiveAnalysisRecommendationProperties { get; set; } = new List<PrescriptiveAnalysisRecommendationProperty>();

    public virtual PrescriptiveRecommendation Recommendation { get; set; }
}
