using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MonthlyAttendanceDetailSummary
{
    public long MonthlyAttendanceDetailId { get; set; }

    public decimal? WeekdayOvertime5Wd { get; set; }

    public decimal? HolidayOvertime5Wd { get; set; }

    public decimal? WeekdayOvertime6Wd { get; set; }

    public decimal? HolidayOvertime6Wd { get; set; }

    public int? LeaderShift { get; set; }

    public int? NightShift { get; set; }

    public int? MealAllowance { get; set; }

    public int? PayCutHours { get; set; }

    public int? WeekdayNightShift { get; set; }

    public int? HolidayNightShift { get; set; }
}
