using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MonitoredSqlserver
{
    public int SqlserverId { get; set; }

    public string InstanceName { get; set; } = null!;

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public DateTime RegisteredDate { get; set; }

    public Guid? CollectionServiceId { get; set; }

    public bool UseIntegratedSecurity { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool EncryptData { get; set; }

    public bool TrustServerCert { get; set; }

    public int ScheduledCollectionIntervalInSeconds { get; set; }

    public DateTime? LastScheduledCollectionTime { get; set; }

    public string? ServerVersion { get; set; }

    public string? ServerEdition { get; set; }

    public bool MaintenanceModeEnabled { get; set; }

    public bool QueryMonitorEnabled { get; set; }

    public bool QueryMonitorSqlBatchEventsEnabled { get; set; }

    public bool QueryMonitorSqlStatementEventsEnabled { get; set; }

    public bool QueryMonitorStoredProcedureEventsEnabled { get; set; }

    public int QueryMonitorDurationFilterInMilliseconds { get; set; }

    public int QueryMonitorCpuUsageFilterInMilliseconds { get; set; }

    public int QueryMonitorLogicalDiskReadsFilter { get; set; }

    public int QueryMonitorPhysicalDiskWritesFilter { get; set; }

    public int QueryMonitorTraceFileSizeKb { get; set; }

    public int QueryMonitorTraceFileRollovers { get; set; }

    public int QueryMonitorTraceRecordsPerRefresh { get; set; }

    public bool ActivityMonitorEnabled { get; set; }

    public bool ActivityMonitorDeadlockEventsEnabled { get; set; }

    public bool ActivityMonitorAutoGrowEventsEnabled { get; set; }

    public bool ActivityMonitorBlockingEventsEnabled { get; set; }

    public int ActivityMonitorBlockedProcessThreshold { get; set; }

    public DateTime? GrowthStatisticsStartTime { get; set; }

    public DateTime? ReorgStatisticsStartTime { get; set; }

    public DateTime? LastGrowthStatisticsRunTime { get; set; }

    public DateTime? LastGrowthStatisticsRunTimeUtc { get; set; }

    public DateTime? LastReorgStatisticsRunTime { get; set; }

    public DateTime? LastReorgStatisticsRunTimeUtc { get; set; }

    public DateTime? EarliestDateImportedFromLegacySqldm { get; set; }

    public byte? GrowthStatisticsDays { get; set; }

    public byte? ReorgStatisticsDays { get; set; }

    public string? TableStatisticsExcludedDatabases { get; set; }

    public int GroomAlerts { get; set; }

    public int GroomMetrics { get; set; }

    public int GroomTasks { get; set; }

    public int ReorgMinTableSizeKb { get; set; }

    public int GroomActivity { get; set; }

    public int? CustomCounterTimeoutInSeconds { get; set; }

    public bool? OutOfProcOleAutomation { get; set; }

    public bool? DisableReplicationMonitoring { get; set; }

    public int? MaintenanceModeType { get; set; }

    public DateTime? MaintenanceModeStart { get; set; }

    public DateTime? MaintenanceModeStop { get; set; }

    public short? MaintenanceModeDays { get; set; }

    public int? MaintenanceModeDurationSeconds { get; set; }

    public DateTime? MaintenanceModeRecurringStart { get; set; }

    public string? QueryMonitorAdvancedConfiguration { get; set; }

    public bool? DisableExtendedHistoryCollection { get; set; }

    public bool? RefRangeUseDefaults { get; set; }

    public DateTime? RefRangeStartTimeUtc { get; set; }

    public DateTime? RefRangeEndTimeUtc { get; set; }

    public byte? RefRangeDays { get; set; }

    public bool? DisableOleAutomation { get; set; }

    public string? DiskCollectionSettings { get; set; }

    public DateTime? QueryMonitorStopTimeUtc { get; set; }

    public int InputBufferLimiter { get; set; }

    public bool InputBufferLimited { get; set; }

    public string? ActiveClusterNode { get; set; }

    public string? PreferredClusterNode { get; set; }

    public string? RealServerName { get; set; }

    public string? FriendlyServerName { get; set; }

    public DateTime? ActiveWaitCollectorStartTimeRelative { get; set; }

    public int? ActiveWaitCollectorRunTimeSeconds { get; set; }

    public int? ActiveWaitCollectorCollectionTimeSeconds { get; set; }

    public bool? ActiveWaitCollectorEnabled { get; set; }

    public int? ActiveWaitLoopTimeMilliseconds { get; set; }

    public string? ActiveWaitAdvancedConfiguration { get; set; }

    public bool ActiveWaitXeenable { get; set; }

    public int ActiveWaitXefileSizeMb { get; set; }

    public int ActiveWaitXefilesRollover { get; set; }

    public int ActiveWaitXerecordsPerRefresh { get; set; }

    public int ActiveWaitXemaxMemoryMb { get; set; }

    public byte ActiveWaitXeeventRetentionMode { get; set; }

    public int ActiveWaitXemaxDispatchLatencySecs { get; set; }

    public int ActiveWaitXemaxEventSizeMb { get; set; }

    public int ActiveWaitXememoryPartitionMode { get; set; }

    public bool ActiveWaitXetrackCausality { get; set; }

    public bool ActiveWaitXestartupState { get; set; }

    public string ActiveWaitsXefileName { get; set; } = null!;

    public short? ClusterCollectionSetting { get; set; }

    public short ServerPingInterval { get; set; }

    public int? VhostId { get; set; }

    public string? VmUid { get; set; }

    public string? VmName { get; set; }

    public string? VmDomainName { get; set; }

    public bool AlertRefreshInMinutes { get; set; }

    public int DatabaseStatisticsRefreshIntervalInSeconds { get; set; }

    public bool WmiCollectionEnabled { get; set; }

    public bool WmiConnectAsService { get; set; }

    public string? WmiUserName { get; set; }

    public string? WmiPassword { get; set; }

    public DateTime? LastDatabaseCollectionTime { get; set; }

    public DateTime? LastAlertRefreshTime { get; set; }

    public int GroomAudit { get; set; }

    public int? MaintenanceModeMonth { get; set; }

    public int? MaintenanceModeSpecificDay { get; set; }

    public int? MaintenanceModeWeekOrdinal { get; set; }

    public int? MaintenanceModeWeekDay { get; set; }

    public int? MaintenanceModeMonthDuration { get; set; }

    public DateTime? MaintenanceModeMonthRecurringStart { get; set; }

    public bool QueryMonitorTraceMonitoringEnabled { get; set; }

    public bool QueryMonitorCollectQueryPlan { get; set; }

    public bool QueryMonitorCollectEstimatedQueryPlan { get; set; }

    public bool ActivityMonitorTraceMonitoringEnabled { get; set; }

    public int ActivityMonitorXefileSizeMb { get; set; }

    public int ActivityMonitorXefilesRollover { get; set; }

    public int ActivityMonitorXerecordsPerRefresh { get; set; }

    public int ActivityMonitorXemaxMemoryMb { get; set; }

    public byte ActivityMonitorXeeventRetentionMode { get; set; }

    public int ActivityMonitorXemaxDispatchLatencySecs { get; set; }

    public int ActivityMonitorXemaxEventSizeMb { get; set; }

    public int ActivityMonitorXememoryPartitionMode { get; set; }

    public bool ActivityMonitorXetrackCausality { get; set; }

    public bool ActivityMonitorXestartupState { get; set; }

    public string ActivityMonitorXefileName { get; set; } = null!;

    public int QueryMonitorXefileSizeMb { get; set; }

    public int QueryMonitorXefilesRollover { get; set; }

    public int? CloudProviderId { get; set; }

    public int GroomPrescriptiveAnalysis { get; set; }

    public double? InstanceScaleFactor { get; set; }

    public bool IsUserSysAdmin { get; set; }

    public int QueryMonitorTopPlanCountFilter { get; set; }

    public int QueryMonitorTopPlanCategoryFilter { get; set; }

    public bool QueryMonitorQueryStoreMonitoringEnabled { get; set; }

    public bool ActiveWaitQsEnable { get; set; }

    public bool? MaintenanceModeOnDemand { get; set; }

    public string? AwsAccessKey { get; set; }

    public string? AwsSecretKey { get; set; }

    public string? AwsRegionEndpoint { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual ICollection<AlwaysOnReplica> AlwaysOnReplicas { get; set; } = new List<AlwaysOnReplica>();

    public virtual ICollection<AzureProfile> AzureProfiles { get; set; } = new List<AzureProfile>();

    public virtual ICollection<BaselineStatistic> BaselineStatistics { get; set; } = new List<BaselineStatistic>();

    public virtual ICollection<BaselineTemplate> BaselineTemplates { get; set; } = new List<BaselineTemplate>();

    public virtual ICollection<Block> Blocks { get; set; } = new List<Block>();

    public virtual ICollection<CustomCounterStatistic> CustomCounterStatistics { get; set; } = new List<CustomCounterStatistic>();

    public virtual ICollection<Deadlock> Deadlocks { get; set; } = new List<Deadlock>();

    public virtual ICollection<EsxconfigDatum> EsxconfigData { get; set; } = new List<EsxconfigDatum>();

    public virtual ICollection<Esxstatistic> Esxstatistics { get; set; } = new List<Esxstatistic>();

    public virtual ICollection<MetricThreshold> MetricThresholds { get; set; } = new List<MetricThreshold>();

    public virtual MonitoredServerSqlsafeInstance? MonitoredServerSqlsafeInstance { get; set; }

    public virtual ICollection<Osstatistic> Osstatistics { get; set; } = new List<Osstatistic>();

    public virtual ICollection<PredictiveForecast> PredictiveForecasts { get; set; } = new List<PredictiveForecast>();

    public virtual ICollection<PredictiveModel> PredictiveModels { get; set; } = new List<PredictiveModel>();

    public virtual ICollection<QuerySignatureAggregation> QuerySignatureAggregations { get; set; } = new List<QuerySignatureAggregation>();

    public virtual ICollection<ServerActivity> ServerActivities { get; set; } = new List<ServerActivity>();

    public virtual ICollection<ServerStatistic> ServerStatistics { get; set; } = new List<ServerStatistic>();

    public virtual ICollection<SqlserverDatabaseName> SqlserverDatabaseNames { get; set; } = new List<SqlserverDatabaseName>();

    public virtual ICollection<VmconfigDatum> VmconfigData { get; set; } = new List<VmconfigDatum>();

    public virtual ICollection<Vmstatistic> Vmstatistics { get; set; } = new List<Vmstatistic>();

    public virtual ICollection<WaitStatistic> WaitStatistics { get; set; } = new List<WaitStatistic>();

    public virtual ICollection<MetricMetaDatum> Metrics { get; set; } = new List<MetricMetaDatum>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();

    public virtual ICollection<CustomDashboardWidget> Widgets { get; set; } = new List<CustomDashboardWidget>();
}
