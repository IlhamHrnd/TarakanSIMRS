using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisConfigCategory
{
    public int AnalysisConfigurationId { get; set; }

    public int CategoryId { get; set; }

    public virtual AnalysisConfiguration AnalysisConfiguration { get; set; } = null!;

    public virtual PrescriptiveRecommendationCategory Category { get; set; } = null!;
}
