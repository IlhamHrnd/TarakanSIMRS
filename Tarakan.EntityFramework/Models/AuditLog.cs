using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AuditLog
{
    public int AuditLogId { get; set; }

    public string TableName { get; set; } = null!;

    public string AuditActionType { get; set; } = null!;

    public string PrimaryKeyData { get; set; } = null!;

    public string ActionByUserId { get; set; } = null!;

    public DateTime LogDateTime { get; set; }
}
