using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysisSnapshotValuesPreviou
{
    public int MonitoredServerId { get; set; }

    public int ActiveNetworkCards { get; set; }

    public long TotalNetworkBandwidth { get; set; }

    public int AllowedProcessorCount { get; set; }

    public long TotalNumberOfLogicalProcessors { get; set; }

    public long TotalMaxClockSpeed { get; set; }

    public long TotalPhysicalMemory { get; set; }

    public long MaxServerMemory { get; set; }

    public string? WindowsVersion { get; set; }

    public string? ProductVersion { get; set; }

    public string? SqlversionString { get; set; }
}
