using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public byte[] LoginSid { get; set; } = null!;

    public int Permission1 { get; set; }

    public bool Enabled { get; set; }

    public string? Comment { get; set; }

    public bool WebAppPermission { get; set; }

    public virtual ICollection<MonitoredSqlserver> Sqlservers { get; set; } = new List<MonitoredSqlserver>();

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
