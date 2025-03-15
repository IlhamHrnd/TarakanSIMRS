using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ActiveWaitStatistic
{
    public int ActiveWaitId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public DateTime StatementUtcstartTime { get; set; }

    public DateTime? StatementLocalStartTime { get; set; }

    public long? WaitDuration { get; set; }

    public short? SessionId { get; set; }

    public int? WaitTypeId { get; set; }

    public int? HostNameId { get; set; }

    public int? ApplicationNameId { get; set; }

    public int? LoginNameId { get; set; }

    public int? DatabaseId { get; set; }

    public int? SqlstatementId { get; set; }

    public long? Msticks { get; set; }

    public int? SqlsignatureId { get; set; }

    public virtual ApplicationName? ApplicationName { get; set; }

    public virtual SqlserverDatabaseName? Database { get; set; }

    public virtual HostName? HostName { get; set; }

    public virtual LoginName? LoginName { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;

    public virtual Sqlstatement? Sqlstatement { get; set; }

    public virtual WaitType? WaitType { get; set; }
}
