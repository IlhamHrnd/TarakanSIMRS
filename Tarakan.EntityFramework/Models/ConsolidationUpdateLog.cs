using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ConsolidationUpdateLog
{
    public long UpdateId { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public string? HealthcareId { get; set; }

    public bool IsManualLog { get; set; }

    public string UpdateSummary { get; set; } = null!;

    public string UpdateData { get; set; } = null!;

    public long? StartConsolidationLogId { get; set; }

    public long? EndConsolidationLogId { get; set; }

    public DateTime? SuccessUpdateDateTime { get; set; }

    public bool? IsError { get; set; }

    public string? ErrorMessage { get; set; }

    public long? ReferenceId { get; set; }

    public string? ReferenceNote { get; set; }
}
