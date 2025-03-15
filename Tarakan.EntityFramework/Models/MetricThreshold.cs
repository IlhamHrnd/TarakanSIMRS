using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricThreshold
{
    public int SqlserverId { get; set; }

    public int Metric { get; set; }

    public bool Enabled { get; set; }

    public string? WarningThreshold { get; set; }

    public string? CriticalThreshold { get; set; }

    public string? Data { get; set; }

    public DateTime? UtcsnoozeStart { get; set; }

    public DateTime? UtcsnoozeEnd { get; set; }

    public string? SnoozeStartUser { get; set; }

    public string? SnoozeEndUser { get; set; }

    public string? InfoThreshold { get; set; }

    public int ThresholdInstanceId { get; set; }

    public bool ThresholdEnabled { get; set; }

    public bool IsBaselineEnabled { get; set; }

    public string? BaselineWarningThreshold { get; set; }

    public string? BaselineCriticalThreshold { get; set; }

    public string? BaselineInfoThreshold { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
