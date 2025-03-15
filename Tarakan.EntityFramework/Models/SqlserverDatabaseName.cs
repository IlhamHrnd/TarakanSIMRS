using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlserverDatabaseName
{
    public int DatabaseId { get; set; }

    public int SqlserverId { get; set; }

    public string DatabaseName { get; set; } = null!;

    public bool SystemDatabase { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<DatabaseFile> DatabaseFiles { get; set; } = new List<DatabaseFile>();

    public virtual ICollection<DatabaseSizeDateTime> DatabaseSizeDateTimes { get; set; } = new List<DatabaseSizeDateTime>();

    public virtual ICollection<DatabaseSize> DatabaseSizes { get; set; } = new List<DatabaseSize>();

    public virtual ICollection<DatabaseStatistic> DatabaseStatistics { get; set; } = new List<DatabaseStatistic>();

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();

    public virtual MirroringParticipant? MirroringParticipant { get; set; }

    public virtual ICollection<MirroringStatistic> MirroringStatistics { get; set; } = new List<MirroringStatistic>();

    public virtual ICollection<QuerySignatureAggregation> QuerySignatureAggregations { get; set; } = new List<QuerySignatureAggregation>();

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;

    public virtual ICollection<SqlserverTableName> SqlserverTableNames { get; set; } = new List<SqlserverTableName>();
}
