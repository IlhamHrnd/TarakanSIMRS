using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QueryMonitorStatistic
{
    public int QueryStatisticsId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public DateTime StatementUtcstartTime { get; set; }

    public DateTime? StatementLocalStartTime { get; set; }

    public DateTime? CompletionTime { get; set; }

    public long? DurationMilliseconds { get; set; }

    public long? Cpumilliseconds { get; set; }

    public long? Reads { get; set; }

    public long? Writes { get; set; }

    public int? HostNameId { get; set; }

    public int? ApplicationNameId { get; set; }

    public int? LoginNameId { get; set; }

    public int? DatabaseId { get; set; }

    public int? StatementType { get; set; }

    public int? SqlstatementId { get; set; }

    public int? SqlsignatureId { get; set; }

    public short? SessionId { get; set; }

    public int? PlanId { get; set; }

    public virtual ApplicationName ApplicationName { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }

    public virtual HostName HostName { get; set; }

    public virtual LoginName LoginName { get; set; }

    public virtual SqlqueryPlan Plan { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }

    public virtual Sqlsignature Sqlsignature { get; set; }

    public virtual Sqlstatement Sqlstatement { get; set; }
}
