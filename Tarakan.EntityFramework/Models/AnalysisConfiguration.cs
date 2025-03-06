using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisConfiguration
{
    public int Id { get; set; }

    public int MonitoredServerId { get; set; }

    public bool ProductionServer { get; set; }

    public bool Oltp { get; set; }

    public DateTime? StartTime { get; set; }

    public int? Duration { get; set; }

    public short ScheduledDays { get; set; }

    public int? IncludeDatabase { get; set; }

    public bool IsActive { get; set; }

    public string FilterApplication { get; set; }

    public bool SchedulingStatus { get; set; }
}
