using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AdvanceFilteringAlert
{
    public long Id { get; set; }

    public string? ServerName { get; set; }

    public int? Metric { get; set; }

    public string? ThresholdType { get; set; }

    public int? CurrentVoilentionCount { get; set; }

    public int? TotalSnapShot { get; set; }

    public string? DatabaseName { get; set; }
}
