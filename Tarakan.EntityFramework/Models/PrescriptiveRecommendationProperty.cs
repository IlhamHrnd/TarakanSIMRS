using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveRecommendationProperty
{
    public int Id { get; set; }

    public string RecommendationId { get; set; } = null!;

    public string PropertyName { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalysisRecommendationProperty> PrescriptiveAnalysisRecommendationProperties { get; set; } = new List<PrescriptiveAnalysisRecommendationProperty>();

    public virtual PrescriptiveRecommendation Recommendation { get; set; } = null!;
}
