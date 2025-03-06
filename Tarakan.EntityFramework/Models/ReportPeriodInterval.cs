using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReportPeriodInterval
{
    public int ReportNumber { get; set; }

    public int PeriodValue { get; set; }

    public int IntervalValue { get; set; }
}
