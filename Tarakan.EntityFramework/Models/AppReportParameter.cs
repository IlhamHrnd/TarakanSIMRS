using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppReportParameter
{
    public string ProgramId { get; set; }

    public string ParameterName { get; set; }

    public string ReportControlName { get; set; }

    public int IndexNo { get; set; }

    public string ParameterCaption { get; set; }
}
