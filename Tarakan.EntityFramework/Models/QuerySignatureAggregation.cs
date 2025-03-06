using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuerySignatureAggregation
{
    public int QuerySignatureAggregationId { get; set; }

    public int? SqlserverId { get; set; }

    public DateTime? EventUtcstartTime { get; set; }

    public decimal? QueryMonitorOccurrences { get; set; }

    public decimal? WaitOcurrences { get; set; }

    public decimal? BlockingOcurrences { get; set; }

    public decimal? DeadlockOcurrences { get; set; }

    public decimal? TotalDurationMilliseconds { get; set; }

    public decimal? MaxDurationMilliseconds { get; set; }

    public decimal? TotalCpumilliseconds { get; set; }

    public decimal? MaxCpumilliseconds { get; set; }

    public decimal? TotalReads { get; set; }

    public decimal? MaxReads { get; set; }

    public decimal? TotalWrites { get; set; }

    public decimal? MaxWrites { get; set; }

    public int? StatementType { get; set; }

    public decimal? TotalBlockingDurationMilliseconds { get; set; }

    public decimal? MaxBlockingDurationMilliseconds { get; set; }

    public decimal? TotalWaitDuration { get; set; }

    public decimal? MaxWaitDuration { get; set; }

    public int? ApplicationNameId { get; set; }

    public int? DatabaseId { get; set; }

    public int? SqlsignatureId { get; set; }

    public virtual ApplicationName ApplicationName { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }

    public virtual Sqlsignature Sqlsignature { get; set; }
}
