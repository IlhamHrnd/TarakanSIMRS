using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double? TagScaleFactor { get; set; }

    public virtual ICollection<CustomCounterDefinition> Metrics { get; set; } = new List<CustomCounterDefinition>();

    public virtual ICollection<MonitoredSqlserver> Sqlservers { get; set; } = new List<MonitoredSqlserver>();

    public virtual ICollection<CustomDashboardWidget> Widgets { get; set; } = new List<CustomDashboardWidget>();
}
