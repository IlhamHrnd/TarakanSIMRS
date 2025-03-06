using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomDashboardMatchType
{
    public int MatchId { get; set; }

    public string MatchType { get; set; }

    public virtual ICollection<CustomDashboardWidget> CustomDashboardWidgets { get; set; } = new List<CustomDashboardWidget>();
}
