using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlsafeConnection
{
    public int RepositoryId { get; set; }

    public string? FriendlyName { get; set; }

    public string InstanceName { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public bool SecurityMode { get; set; }

    public string? UserName { get; set; }

    public string? EncryptedPassword { get; set; }

    public DateTime? RegisteredDate { get; set; }

    public virtual ICollection<MonitoredServerSqlsafeInstance> MonitoredServerSqlsafeInstances { get; set; } = new List<MonitoredServerSqlsafeInstance>();
}
