using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ConsolidationLog
{
    public int ConsolidationLogId { get; set; }

    public string? HealthcareId { get; set; }

    public bool IsManualLog { get; set; }

    public string TableName { get; set; } = null!;

    public string ConsolidationType { get; set; } = null!;

    public string PrimaryKeyData { get; set; } = null!;

    public DateTime LogDateTime { get; set; }

    public bool? IsSend { get; set; }
}
