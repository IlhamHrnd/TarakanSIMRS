using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppReportPivot
{
    public string ProgramId { get; set; } = null!;

    public int CustomPivotId { get; set; }

    public string FieldCaption { get; set; } = null!;

    public string? UserId { get; set; }

    public int PivotArea { get; set; }

    public int IndexNo { get; set; }

    public string FieldName { get; set; } = null!;

    public int? GroupInterval { get; set; }

    public int? SummaryType { get; set; }

    public int? FormatType { get; set; }

    public string? FormatString { get; set; }

    public int? GroupIndex { get; set; }

    public int? InnerGroupIndex { get; set; }
}
