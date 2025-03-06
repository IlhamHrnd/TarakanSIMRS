using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DeadlockProcess
{
    public int DeadlockProcessId { get; set; }

    public Guid? DeadlockId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public DateTime? UtcoccurrenceDateTime { get; set; }

    public DateTime? LocalOccurrenceDateTime { get; set; }

    public int? HostNameId { get; set; }

    public int? ApplicationNameId { get; set; }

    public int? LoginNameId { get; set; }

    public int? DatabaseId { get; set; }

    public int? SqlstatementId { get; set; }

    public int? SqlsignatureId { get; set; }

    public short? SessionId { get; set; }

    public virtual ApplicationName ApplicationName { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }

    public virtual Deadlock Deadlock { get; set; }

    public virtual HostName HostName { get; set; }

    public virtual LoginName LoginName { get; set; }

    public virtual Sqlsignature Sqlsignature { get; set; }

    public virtual Sqlstatement Sqlstatement { get; set; }
}
