using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ScomalertEvent
{
    public int MetricId { get; set; }

    public bool IsInScomasAlert { get; set; }

    public Guid RuleId { get; set; }

    public virtual MetricMetaDatum Metric { get; set; } = null!;

    public virtual NotificationRule Rule { get; set; } = null!;
}
