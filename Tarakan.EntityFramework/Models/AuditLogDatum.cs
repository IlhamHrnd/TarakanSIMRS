using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AuditLogDatum
{
    public int AuditLogId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public bool? IsInPrimaryKey { get; set; }
}
