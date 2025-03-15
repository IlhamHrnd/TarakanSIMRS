using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveRecommendation
{
    public string RecommendationId { get; set; } = null!;

    public string? AdditionalConsiderations { get; set; }

    public string? Bitly { get; set; }

    public int CategoryId { get; set; }

    public int? ConfidenceFactor { get; set; }

    public string? Description { get; set; }

    public string? Finding { get; set; }

    public string? ImpactExplanation { get; set; }

    public int? ImpactFactor { get; set; }

    public string? InfoLinks { get; set; }

    public string? PluralFormFinding { get; set; }

    public string? PluralFormImpactExplanation { get; set; }

    public string? PluralFormRecommendation { get; set; }

    public string? ProblemExplanation { get; set; }

    public string? Recommendation { get; set; }

    public int? Relevance { get; set; }

    public string? Tags { get; set; }

    public bool IsActive { get; set; }

    public virtual PrescriptiveRecommendationCategory Category { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalysisRecommendation> PrescriptiveAnalysisRecommendations { get; set; } = new List<PrescriptiveAnalysisRecommendation>();

    public virtual ICollection<PrescriptiveRecommendationProperty> PrescriptiveRecommendationProperties { get; set; } = new List<PrescriptiveRecommendationProperty>();
}
