using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppReportParameterHealthcare
{
    public string ProgramId { get; set; }

    public string HealthcareInitial { get; set; }

    public string ParameterName { get; set; }

    public string ReportControlName { get; set; }

    public int IndexNo { get; set; }

    public string ParameterCaption { get; set; }
}
