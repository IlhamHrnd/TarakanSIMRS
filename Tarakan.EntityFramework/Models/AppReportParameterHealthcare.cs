using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppReportParameterHealthcare
{
    public string ProgramId { get; set; } = null!;

    public string HealthcareInitial { get; set; } = null!;

    public string ParameterName { get; set; } = null!;

    public string ReportControlName { get; set; } = null!;

    public int IndexNo { get; set; }

    public string ParameterCaption { get; set; } = null!;
}
