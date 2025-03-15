using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Esxstatistic
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public double? Cpuusage { get; set; }

    public int? CpuusageMhz { get; set; }

    public long? MemSwapInRate { get; set; }

    public long? MemSwapOutRate { get; set; }

    public long? MemActive { get; set; }

    public long? MemConsumed { get; set; }

    public long? MemGranted { get; set; }

    public long? MemBalooned { get; set; }

    public double? MemUsage { get; set; }

    public long? DiskRead { get; set; }

    public long? DiskWrite { get; set; }

    public long? DiskDeviceLatency { get; set; }

    public long? DiskKernelLatency { get; set; }

    public long? DiskQueueLatency { get; set; }

    public long? DiskTotalLatency { get; set; }

    public long? DiskUsage { get; set; }

    public long? NetUsage { get; set; }

    public long? NetReceived { get; set; }

    public long? NetTransmitted { get; set; }

    public long? MemPagePerSec { get; set; }

    public long? AvailableMemBytes { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
