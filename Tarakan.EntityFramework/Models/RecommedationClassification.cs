using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RecommedationClassification
{
    public string RecommendationId { get; set; }

    public bool? Aws { get; set; }

    public bool? Azure { get; set; }

    public bool? OnPremisesDb { get; set; }
}
