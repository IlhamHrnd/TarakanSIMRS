using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Deadlock
{
    public Guid DeadlockId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string? Xdldata { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
