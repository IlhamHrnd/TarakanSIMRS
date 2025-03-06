using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Vmstatistic
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public double? Cpuusage { get; set; }

    public int? CpuusageMhz { get; set; }

    public long? Cpuready { get; set; }

    public long? CpuswapWait { get; set; }

    public long? MemSwapInRate { get; set; }

    public long? MemSwapOutRate { get; set; }

    public long? MemSwapped { get; set; }

    public long? MemActive { get; set; }

    public long? MemConsumed { get; set; }

    public long? MemGranted { get; set; }

    public long? MemBalooned { get; set; }

    public double? MemUsage { get; set; }

    public long? DiskRead { get; set; }

    public long? DiskWrite { get; set; }

    public long? DiskUsage { get; set; }

    public long? NetUsage { get; set; }

    public long? NetReceived { get; set; }

    public long? NetTransmitted { get; set; }

    public long? PagePerSecVm { get; set; }

    public long? AvailableByteVm { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }
}
