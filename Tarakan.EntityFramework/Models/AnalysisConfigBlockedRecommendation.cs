using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisConfigBlockedRecommendation
{
    public int AnalysisConfigurationId { get; set; }

    public string RecommendationId { get; set; }

    public virtual AnalysisConfiguration AnalysisConfiguration { get; set; }

    public virtual PrescriptiveRecommendation Recommendation { get; set; }
}
