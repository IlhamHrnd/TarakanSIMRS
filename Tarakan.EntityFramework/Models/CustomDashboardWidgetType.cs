using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomDashboardWidgetType
{
    public int WidgetTypeId { get; set; }

    public string WidgetType { get; set; } = null!;

    public virtual ICollection<CustomDashboardWidget> CustomDashboardWidgets { get; set; } = new List<CustomDashboardWidget>();
}
