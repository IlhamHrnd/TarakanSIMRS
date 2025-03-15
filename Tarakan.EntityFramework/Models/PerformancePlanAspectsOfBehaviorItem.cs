using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanAspectsOfBehaviorItem
{
    public int AspectsOfBehaviorItemId { get; set; }

    public int AspectsOfBehaviorId { get; set; }

    public string RatedAspectCode { get; set; } = null!;

    public string RatedAspectName { get; set; } = null!;

    public string RatedAspectDescription { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
