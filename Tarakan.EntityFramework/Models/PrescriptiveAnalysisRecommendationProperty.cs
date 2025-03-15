using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysisRecommendationProperty
{
    public int Id { get; set; }

    public int AnalysisRecommendationId { get; set; }

    public int PropertyId { get; set; }

    public string? Value { get; set; }

    public virtual PrescriptiveAnalysisRecommendation AnalysisRecommendation { get; set; } = null!;

    public virtual PrescriptiveRecommendationProperty Property { get; set; } = null!;
}
