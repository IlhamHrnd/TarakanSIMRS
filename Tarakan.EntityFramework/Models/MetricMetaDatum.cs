using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricMetaDatum
{
    public int Metric { get; set; }

    public DateTime UtclastChangeDateTime { get; set; }

    public bool Deleted { get; set; }

    public int Class { get; set; }

    public int Flags { get; set; }

    public int MinValue { get; set; }

    public long MaxValue { get; set; }

    public long DefaultWarningValue { get; set; }

    public long DefaultCriticalValue { get; set; }

    public bool DoNotifications { get; set; }

    public int? EventCategory { get; set; }

    public int? DefaultMessageId { get; set; }

    public bool AlertEnabledDefault { get; set; }

    public int ValueComparison { get; set; }

    public string ValueType { get; set; } = null!;

    public int? Rank { get; set; }

    public long DefaultInfoValue { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public bool IsValidForSqlExpress { get; set; }

    public long BaselineMaxValue { get; set; }

    public long BaselineDefaultWarningValue { get; set; }

    public long BaselineDefaultCriticalValue { get; set; }

    public long BaselineDefaultInfoValue { get; set; }

    public virtual ICollection<ScomalertEvent> ScomalertEvents { get; set; } = new List<ScomalertEvent>();

    public virtual ICollection<MonitoredSqlserver> Sqlservers { get; set; } = new List<MonitoredSqlserver>();
}
