using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServerStatistic
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public double TimeDeltaInSeconds { get; set; }

    public int? AgentServiceStatus { get; set; }

    public double? DataIousage { get; set; }

    public double? LogIousage { get; set; }

    public double? DataIorate { get; set; }

    public double? LogIorate { get; set; }

    public int? SqlServerServiceStatus { get; set; }

    public int? DtcserviceStatus { get; set; }

    public int? FullTextSearchStatus { get; set; }

    public double? BufferCacheHitRatioPercentage { get; set; }

    public long? CheckpointWrites { get; set; }

    public int? ClientComputers { get; set; }

    public double? CpuactivityPercentage { get; set; }

    public long? CputimeDelta { get; set; }

    public long? CputimeRaw { get; set; }

    public long? FullScans { get; set; }

    public long? IdleTimeDelta { get; set; }

    public double? IdleTimePercentage { get; set; }

    public long? IdleTimeRaw { get; set; }

    public double? IoactivityPercentage { get; set; }

    public long? IotimeDelta { get; set; }

    public long? IotimeRaw { get; set; }

    public long? LazyWriterWrites { get; set; }

    public long? LockWaits { get; set; }

    public long? Logins { get; set; }

    public long? LogFlushes { get; set; }

    public long? SqlMemoryAllocatedInKilobytes { get; set; }

    public long? SqlMemoryUsedInKilobytes { get; set; }

    public long? OldestOpenTransactionsInMinutes { get; set; }

    public long? PacketErrors { get; set; }

    public long? PacketsReceived { get; set; }

    public long? PacketsSent { get; set; }

    public long? PageErrors { get; set; }

    public long? PageLifeExpectancy { get; set; }

    public long? PageLookups { get; set; }

    public long? PageReads { get; set; }

    public long? PageSplits { get; set; }

    public long? PageWrites { get; set; }

    public double? ProcedureCacheHitRatioPercentage { get; set; }

    public long? ProcedureCacheSizeInKilobytes { get; set; }

    public double? ProcedureCacheSizePercent { get; set; }

    public long? ReadAheadPages { get; set; }

    public double? ReplicationLatencyInSeconds { get; set; }

    public double? DistributionLatencyInSeconds { get; set; }

    public long? ReplicationSubscribed { get; set; }

    public long? ReplicationUndistributed { get; set; }

    public long? ReplicationUnsubscribed { get; set; }

    public int? ResponseTimeInMilliseconds { get; set; }

    public string? ServerVersion { get; set; }

    public long? SqlCompilations { get; set; }

    public long? SqlRecompilations { get; set; }

    public long? TableLockEscalations { get; set; }

    public long? TempDbsizeInKilobytes { get; set; }

    public double? TempDbsizePercent { get; set; }

    public long? Batches { get; set; }

    public int? UserProcesses { get; set; }

    public long? WorkFilesCreated { get; set; }

    public long? WorkTablesCreated { get; set; }

    public int? SystemProcesses { get; set; }

    public int? UserProcessesConsumingCpu { get; set; }

    public int? SystemProcessesConsumingCpu { get; set; }

    public int? BlockedProcesses { get; set; }

    public int? OpenTransactions { get; set; }

    public int? DatabaseCount { get; set; }

    public int? DataFileCount { get; set; }

    public int? LogFileCount { get; set; }

    public decimal? DataFileSpaceAllocatedInKilobytes { get; set; }

    public decimal? DataFileSpaceUsedInKilobytes { get; set; }

    public decimal? LogFileSpaceAllocatedInKilobytes { get; set; }

    public decimal? LogFileSpaceUsedInKilobytes { get; set; }

    public decimal? TotalLocks { get; set; }

    public long? BufferCacheSizeInKilobytes { get; set; }

    public int? ActiveProcesses { get; set; }

    public int? LeadBlockers { get; set; }

    public long? CommittedInKilobytes { get; set; }

    public long? ConnectionMemoryInKilobytes { get; set; }

    public long? FreePagesInKilobytes { get; set; }

    public long? GrantedWorkspaceMemoryInKilobytes { get; set; }

    public long? LockMemoryInKilobytes { get; set; }

    public long? OptimizerMemoryInKilobytes { get; set; }

    public long? TotalServerMemoryInKilobytes { get; set; }

    public long? FreeCachePagesInKilobytes { get; set; }

    public long? CachePagesInKilobytes { get; set; }

    public long? MaxConnections { get; set; }

    public long? PhysicalMemoryInKilobytes { get; set; }

    public int? ProcessorCount { get; set; }

    public int? ProcessorsUsed { get; set; }

    public string? ProcessorType { get; set; }

    public string? ServerHostName { get; set; }

    public string? RealServerName { get; set; }

    public string? WindowsVersion { get; set; }

    public string? SqlServerEdition { get; set; }

    public DateTime? RunningSince { get; set; }

    public bool? IsClustered { get; set; }

    public string? ClusterNodeName { get; set; }

    public string? OsStatisticAvailability { get; set; }

    public long? Transactions { get; set; }

    public long? VersionStoreGenerationKilobytes { get; set; }

    public long? VersionStoreCleanupKilobytes { get; set; }

    public long? TempdbPfswaitTimeMilliseconds { get; set; }

    public long? TempdbGamwaitTimeMilliseconds { get; set; }

    public long? TempdbSgamwaitTimeMilliseconds { get; set; }

    public int? SqlbrowserServiceStatus { get; set; }

    public int? SqlactiveDirectoryHelperServiceStatus { get; set; }

    public decimal? ManagedInstanceStorageLimit { get; set; }

    public double? ReadThroughput { get; set; }

    public double? WriteThroughput { get; set; }

    public double? SwapUsage { get; set; }

    public double? ReadLatency { get; set; }

    public double? WriteLatency { get; set; }

    public double? CpucreditBalance { get; set; }

    public double? CpucreditUsage { get; set; }

    public double? DiskQueueDepth { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
