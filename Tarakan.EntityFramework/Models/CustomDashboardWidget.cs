using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomDashboardWidget
{
    public long WidgetId { get; set; }

    public long DashboardId { get; set; }

    public string WidgetName { get; set; } = null!;

    public int WidgetTypeId { get; set; }

    public int MetricId { get; set; }

    public int MatchId { get; set; }

    public DateTime? RecordCreatedTimestamp { get; set; }

    public DateTime? RecordUpdateDateTimestamp { get; set; }

    public virtual CustomDashboard Dashboard { get; set; } = null!;

    public virtual CustomDashboardMatchType Match { get; set; } = null!;

    public virtual MetricInfo Metric { get; set; } = null!;

    public virtual CustomDashboardWidgetType WidgetType { get; set; } = null!;

    public virtual ICollection<MonitoredSqlserver> SourceServers { get; set; } = new List<MonitoredSqlserver>();

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
