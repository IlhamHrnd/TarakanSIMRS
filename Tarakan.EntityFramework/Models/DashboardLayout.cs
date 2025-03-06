using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DashboardLayout
{
    public int DashboardLayoutId { get; set; }

    public string LoginName { get; set; }

    public string Name { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? LastViewed { get; set; }

    public string Configuration { get; set; }

    public byte[] LayoutImage { get; set; }
}
