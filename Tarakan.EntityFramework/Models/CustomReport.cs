using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CustomReport
{
    public int Id { get; set; }

    public string ReportName { get; set; }

    public string ReportText { get; set; }

    public string ReportShortDescription { get; set; }

    public bool? ShowTopServers { get; set; }

    public virtual ICollection<CustomReportsCounter> CustomReportsCounters { get; set; } = new List<CustomReportsCounter>();
}
