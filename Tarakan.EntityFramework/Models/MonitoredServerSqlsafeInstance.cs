using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MonitoredServerSqlsafeInstance
{
    public int SqlserverId { get; set; }

    public int RepositoryId { get; set; }

    public int RelatedInstanceId { get; set; }

    public int LastBackupActionId { get; set; }

    public int LastDefragActionId { get; set; }

    public virtual SqlsafeConnection Repository { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; }
}
