using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReplicationTopology
{
    public string PublisherInstance { get; set; }

    public string PublisherDb { get; set; }

    public string Publication { get; set; }

    public DateTime? LastPublisherSnapshotDateTime { get; set; }

    public DateTime? LastDistributorSnapshotDateTime { get; set; }

    public DateTime? LastSubscriberSnapshotDateTime { get; set; }

    public string DistributorInstance { get; set; }

    public string DistributorDb { get; set; }

    public string SubscriberInstance { get; set; }

    public string SubscriberDb { get; set; }

    public int? PublisherDbid { get; set; }

    public int? DistributorDbid { get; set; }

    public int? SubscriberDbid { get; set; }

    public int? SubscribedTransactions { get; set; }

    public int? NonSubscribedTransactions { get; set; }

    public int? NonDistributedTransactions { get; set; }

    public double? ReplicationLatency { get; set; }

    public int? MaxSubscriptionLatency { get; set; }

    public byte? ReplicationType { get; set; }

    public byte? SubscriptionType { get; set; }

    public DateTime? LastSubscriberUpdate { get; set; }

    public byte? LastSyncStatus { get; set; }

    public string LastSyncSummary { get; set; }

    public DateTime? LastSyncTime { get; set; }

    public byte? SubscriptionStatus { get; set; }

    public string PublicationDescription { get; set; }

    public int? ArticleCount { get; set; }
}
