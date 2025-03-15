using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanAspectsOfBehavior
{
    public int AspectsOfBehaviorId { get; set; }

    public string AspectsOfBehaviorCode { get; set; } = null!;

    public string AspectsOfBehaviorName { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
