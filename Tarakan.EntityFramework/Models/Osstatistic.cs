using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Osstatistic
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public long? OstotalPhysicalMemoryInKilobytes { get; set; }

    public long? OsavailableMemoryInKilobytes { get; set; }

    public double? PagesPerSecond { get; set; }

    public double? ProcessorTimePercent { get; set; }

    public double? PrivilegedTimePercent { get; set; }

    public double? UserTimePercent { get; set; }

    public double? ProcessorQueueLength { get; set; }

    public double? DiskTimePercent { get; set; }

    public double? DiskQueueLength { get; set; }

    public long? AvailableByteVm { get; set; }

    public long? UsedByteVm { get; set; }

    public long? TotalByteVm { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
