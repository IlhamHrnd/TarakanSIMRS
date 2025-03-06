using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DatabaseStatisticsAggregation
{
    public long AggregatedDatabaseStatisticsId { get; set; }

    public int DatabaseId { get; set; }

    public DateTime MaxUtccollectionDateTime { get; set; }

    public DateTime MinUtccollectionDateTime { get; set; }

    public int? DatabaseStatus { get; set; }

    public long? MaxTransactions { get; set; }

    public long? MinTransactions { get; set; }

    public long? TotalTransactions { get; set; }

    public long? MaxLogFlushWaits { get; set; }

    public long? MinLogFlushWaits { get; set; }

    public long? TotalLogFlushWaits { get; set; }

    public long? MaxLogFlushes { get; set; }

    public long? MinLogFlushes { get; set; }

    public long? TotalLogFlushes { get; set; }

    public long? MaxLogKilobytesFlushed { get; set; }

    public long? MinLogKilobytesFlushed { get; set; }

    public long? TotalLogKilobytesFlushed { get; set; }

    public long? MaxLogCacheReads { get; set; }

    public long? MinLogCacheReads { get; set; }

    public long? TotalLogCacheReads { get; set; }

    public double? MaxLogCacheHitRatio { get; set; }

    public double? MinLogCacheHitRatio { get; set; }

    public double? TotalLogCacheHitRatio { get; set; }

    public double? MaxTimeDeltaInSeconds { get; set; }

    public double? MinTimeDeltaInSeconds { get; set; }

    public double? TotalTimeDeltaInSeconds { get; set; }

    public decimal? MaxNumberReads { get; set; }

    public decimal? MinNumberReads { get; set; }

    public decimal? TotalNumberReads { get; set; }

    public decimal? MaxNumberWrites { get; set; }

    public decimal? MinNumberWrites { get; set; }

    public decimal? TotalNumberWrites { get; set; }

    public decimal? MaxBytesRead { get; set; }

    public decimal? MinBytesRead { get; set; }

    public decimal? TotalBytesRead { get; set; }

    public decimal? MaxBytesWritten { get; set; }

    public decimal? MinBytesWritten { get; set; }

    public decimal? TotalBytesWritten { get; set; }

    public decimal? MaxIoStallMs { get; set; }

    public decimal? MinIoStallMs { get; set; }

    public decimal? TotalIoStallMs { get; set; }

    public DateTime? MaxDatabaseSizeTime { get; set; }

    public DateTime? MinDatabaseSizeTime { get; set; }

    public DateTime? MaxLastBackupDateTime { get; set; }

    public DateTime? MinLastBackupDateTime { get; set; }

    public decimal? MaxAverageDataIo { get; set; }

    public decimal? MinAverageDataIo { get; set; }

    public decimal? MaxAverageLogIo { get; set; }

    public decimal? MinAverageLogIminO { get; set; }

    public decimal? MaxMaxWorker { get; set; }

    public decimal? MinMaxWorker { get; set; }

    public decimal? MaxMaxSession { get; set; }

    public decimal? MinMaxSession { get; set; }

    public decimal? MaxDatabaseAverageMemoryUsage { get; set; }

    public decimal? MinDatabaseAverageMemoryUsage { get; set; }

    public decimal? MaxInMemoryStorageUsage { get; set; }

    public decimal? MinInMemoryStorageUsage { get; set; }

    public decimal? MaxAvgCpuPercent { get; set; }

    public decimal? MinAvgCpuPercent { get; set; }

    public decimal? MaxAvgDataIoPercent { get; set; }

    public decimal? MinAvgDataIoPercent { get; set; }

    public decimal? MaxAvgLogWritePercent { get; set; }

    public decimal? MinAvgLogWritePercent { get; set; }

    public int? MaxDtuLimit { get; set; }

    public int? MinDtuLimit { get; set; }

    public decimal? MaxAzureCloudAllocatedMemory { get; set; }

    public decimal? MinAzureCloudAllocatedMemory { get; set; }

    public decimal? MaxAzureCloudUsedMemory { get; set; }

    public decimal? MinAzureCloudUsedMemory { get; set; }

    public decimal? MaxAzureCloudStorageLimit { get; set; }

    public decimal? MinAzureCloudStorageLimit { get; set; }

    public string ElasticPool { get; set; }
}
