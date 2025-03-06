using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BlockingSessionStatistic
{
    public int BlockingSessionId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public Guid? BlockId { get; set; }

    public DateTime BlockingUtcstartTime { get; set; }

    public DateTime? BlockingLocalStartTime { get; set; }

    public long? BlockingDurationMilliseconds { get; set; }

    public int? HostNameId { get; set; }

    public int? ApplicationNameId { get; set; }

    public int? LoginNameId { get; set; }

    public int? DatabaseId { get; set; }

    public int? SqlstatementId { get; set; }

    public int? SqlsignatureId { get; set; }

    public short? SessionId { get; set; }

    public virtual ApplicationName ApplicationName { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }

    public virtual HostName HostName { get; set; }

    public virtual LoginName LoginName { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }

    public virtual Sqlsignature Sqlsignature { get; set; }

    public virtual Sqlstatement Sqlstatement { get; set; }
}
