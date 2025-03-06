using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserCustomPivot
{
    public string ProgramId { get; set; }

    public int CustomPivotId { get; set; }

    public string UserId { get; set; }

    public string CustomPivotName { get; set; }

    public bool? IsShowColumnGrandTotals { get; set; }

    public bool? IsShowColumnTotals { get; set; }

    public bool? IsShowRowGrandTotals { get; set; }

    public bool? IsShowRowTotals { get; set; }

    public bool? IsShowGrandTotalsForSingleValues { get; set; }

    public bool? IsShowTotalsForSingleValues { get; set; }

    public string SummaryType { get; set; }
}
