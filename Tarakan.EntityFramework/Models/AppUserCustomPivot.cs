using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserCustomPivot
{
    public string ProgramId { get; set; } = null!;

    public int CustomPivotId { get; set; }

    public string UserId { get; set; } = null!;

    public string CustomPivotName { get; set; } = null!;

    public bool? IsShowColumnGrandTotals { get; set; }

    public bool? IsShowColumnTotals { get; set; }

    public bool? IsShowRowGrandTotals { get; set; }

    public bool? IsShowRowTotals { get; set; }

    public bool? IsShowGrandTotalsForSingleValues { get; set; }

    public bool? IsShowTotalsForSingleValues { get; set; }

    public string? SummaryType { get; set; }
}
