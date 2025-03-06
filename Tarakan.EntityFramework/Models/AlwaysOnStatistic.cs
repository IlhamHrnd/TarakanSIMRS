using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlwaysOnStatistic
{
    public long AlwaysOnStatisticsId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public Guid ReplicaId { get; set; }

    public Guid GroupId { get; set; }

    public Guid GroupDatabaseId { get; set; }

    public int DatabaseId { get; set; }

    public int SqlserverId { get; set; }

    public bool IsFailoverReady { get; set; }

    public byte SynchronizationState { get; set; }

    public byte SynchronizationHealth { get; set; }

    public byte DatabaseState { get; set; }

    public bool IsSuspended { get; set; }

    public DateTime? LastHardenedTime { get; set; }

    public long LogSedQueueSize { get; set; }

    public long LogSendRate { get; set; }

    public long RedoQueueSize { get; set; }

    public long RedoRate { get; set; }

    public int? ReplicaRole { get; set; }

    public byte? OperationalState { get; set; }

    public byte? ConnectedState { get; set; }

    public byte? SynchronizationHealthAvailabilityReplica { get; set; }

    public int? LastConnectErrorNumber { get; set; }

    public string LastConnectErrorDescription { get; set; }

    public DateTime? LastConnectErrorTimestamp { get; set; }

    public long? EstimatedDataLossTime { get; set; }

    public int? SynchronizationPerformance { get; set; }

    public long? FilestreamSendRate { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public int? EstimatedRecoveryTime { get; set; }
}
