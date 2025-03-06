using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MetricInfo
{
    public int Metric { get; set; }

    public DateTime UtclastChangeDateTime { get; set; }

    public int Rank { get; set; }

    public string Category { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Comments { get; set; }

    public bool PaaS { get; set; }

    public virtual ICollection<CustomDashboardWidget> CustomDashboardWidgets { get; set; } = new List<CustomDashboardWidget>();
}
