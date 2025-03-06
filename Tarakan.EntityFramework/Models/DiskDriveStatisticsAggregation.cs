using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DiskDriveStatisticsAggregation
{
    public long AggregatedDiskDriveStatisticsId { get; set; }

    public int? SqlserverId { get; set; }

    public DateTime MinUtccollectionDateTime { get; set; }

    public DateTime MaxUtccollectionDateTime { get; set; }

    public string DriveName { get; set; }

    public decimal? MinUnusedSizeKb { get; set; }

    public decimal? MaxUnusedSizeKb { get; set; }

    public decimal? TotalUnusedSizeKb { get; set; }

    public decimal? MinTotalzSieKb { get; set; }

    public decimal? MaxTotalSizeKb { get; set; }

    public decimal? TotalSizeKbperDay { get; set; }

    public long? MinDiskIdlePercent { get; set; }

    public long? MaxDiskIdlePercent { get; set; }

    public long? TotalDiskIdlePercent { get; set; }

    public long? MinDiskReadsPerSecond { get; set; }

    public long? MaxDiskReadsPerSecond { get; set; }

    public long? TotalDiskReadsPerSecond { get; set; }

    public long? MinDiskTransferPerSecond { get; set; }

    public long? MaxDiskTransferPerSecond { get; set; }

    public long? TotalTransferPerSecond { get; set; }

    public long? MinDiskWritesPerSecond { get; set; }

    public long? MaxDiskWritesPerSecond { get; set; }

    public long? TotalDiskWritesPerSecond { get; set; }

    public DateTime? MinDatabaseSizeTime { get; set; }

    public DateTime? MaxDatabaseSizeTime { get; set; }

    public long? MinAverageDiskQueueLength { get; set; }

    public long? MaxAverageDiskQueueLength { get; set; }

    public long? MinAverageDiskMillisecondsPerRead { get; set; }

    public long? MaxAverageDiskMillisecondsPerRead { get; set; }

    public long? MinAverageDiskMillisecondsPerTransfer { get; set; }

    public long? MaxAverageDiskMillisecondsPerTransfer { get; set; }

    public long? MinAverageDiskMillisecondsPerWrite { get; set; }

    public long? MaxAverageDiskMillisecondsPerWrite { get; set; }
}
