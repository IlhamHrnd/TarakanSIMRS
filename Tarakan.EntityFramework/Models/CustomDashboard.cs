using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomDashboard
{
    public long CustomDashboardId { get; set; }

    public string CustomDashboardName { get; set; } = null!;

    public bool? IsDefaultOnUi { get; set; }

    public string? UserSid { get; set; }

    public string? Tags { get; set; }

    public DateTime? RecordCreatedTimestamp { get; set; }

    public DateTime? RecordUpdateDateTimestamp { get; set; }

    public virtual ICollection<CustomDashboardWidget> CustomDashboardWidgets { get; set; } = new List<CustomDashboardWidget>();
}
