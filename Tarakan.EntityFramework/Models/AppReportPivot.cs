using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppReportPivot
{
    public string ProgramId { get; set; }

    public int CustomPivotId { get; set; }

    public string FieldCaption { get; set; }

    public string UserId { get; set; }

    public int PivotArea { get; set; }

    public int IndexNo { get; set; }

    public string FieldName { get; set; }

    public int? GroupInterval { get; set; }

    public int? SummaryType { get; set; }

    public int? FormatType { get; set; }

    public string FormatString { get; set; }

    public int? GroupIndex { get; set; }

    public int? InnerGroupIndex { get; set; }
}
