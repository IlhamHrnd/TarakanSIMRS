using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ConsolidationLog
{
    public int ConsolidationLogId { get; set; }

    public string HealthcareId { get; set; }

    public bool IsManualLog { get; set; }

    public string TableName { get; set; }

    public string ConsolidationType { get; set; }

    public string PrimaryKeyData { get; set; }

    public DateTime LogDateTime { get; set; }

    public bool? IsSend { get; set; }
}
