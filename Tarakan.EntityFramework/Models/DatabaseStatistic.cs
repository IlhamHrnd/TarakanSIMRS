using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseStatistic
{
    public long DatabaseStatisticsId { get; set; }

    public int DatabaseId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public int? DatabaseStatus { get; set; }

    public long? Transactions { get; set; }

    public long? LogFlushWaits { get; set; }

    public long? LogFlushes { get; set; }

    public long? LogKilobytesFlushed { get; set; }

    public long? LogCacheReads { get; set; }

    public double? LogCacheHitRatio { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public decimal? NumberReads { get; set; }

    public decimal? NumberWrites { get; set; }

    public decimal? BytesRead { get; set; }

    public decimal? BytesWritten { get; set; }

    public decimal? IoStallMs { get; set; }

    public DateTime? DatabaseSizeTime { get; set; }

    public DateTime? LastBackupDateTime { get; set; }

    public decimal? AverageDataIo { get; set; }

    public decimal? AverageLogIo { get; set; }

    public decimal? MaxWorker { get; set; }

    public decimal? MaxSession { get; set; }

    public decimal? DatabaseAverageMemoryUsage { get; set; }

    public decimal? InMemoryStorageUsage { get; set; }

    public decimal? AvgCpuPercent { get; set; }

    public decimal? AvgDataIoPercent { get; set; }

    public decimal? AvgLogWritePercent { get; set; }

    public int? DtuLimit { get; set; }

    public decimal? AgverageMemoryUsage { get; set; }

    public decimal? AzureCloudAllocatedMemory { get; set; }

    public decimal? AzureCloudUsedMemory { get; set; }

    public decimal? AzureCloudStorageLimit { get; set; }

    public string? ElasticPool { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; } = null!;
}
