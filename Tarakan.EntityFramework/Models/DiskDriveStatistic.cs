using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DiskDriveStatistic
{
    public int DiskDriveStatisticsId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string DriveName { get; set; }

    public decimal? UnusedSizeKb { get; set; }

    public decimal? TotalSizeKb { get; set; }

    public long? DiskIdlePercent { get; set; }

    public long? AverageDiskQueueLength { get; set; }

    public long? AverageDiskMillisecondsPerRead { get; set; }

    public long? AverageDiskMillisecondsPerTransfer { get; set; }

    public long? AverageDiskMillisecondsPerWrite { get; set; }

    public long? DiskReadsPerSecond { get; set; }

    public long? DiskTransfersPerSecond { get; set; }

    public long? DiskWritesPerSecond { get; set; }

    public DateTime? DatabaseSizeTime { get; set; }
}
