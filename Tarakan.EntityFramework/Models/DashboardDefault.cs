using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DashboardDefault
{
    public int DashboardDefaultId { get; set; }

    public string LoginName { get; set; }

    public int? SqlserverId { get; set; }

    public int DashboardLayoutId { get; set; }
}
