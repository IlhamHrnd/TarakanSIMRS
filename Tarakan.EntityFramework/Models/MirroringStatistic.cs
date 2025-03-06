using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MirroringStatistic
{
    public int DatabaseId { get; set; }

    public Guid MirroringGuid { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public byte? Role { get; set; }

    public byte? MirroringState { get; set; }

    public byte? WitnessStatus { get; set; }

    public int? LogGenerationRate { get; set; }

    public int? UnsentLog { get; set; }

    public int? SendRate { get; set; }

    public int? UnrestoredLog { get; set; }

    public int? RecoveryRate { get; set; }

    public int? TransactionDelay { get; set; }

    public int? TransactionsPerSec { get; set; }

    public int? AverageDelay { get; set; }

    public DateTime? TimeRecorded { get; set; }

    public DateTime? TimeBehind { get; set; }

    public DateTime? LocalTime { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }
}
