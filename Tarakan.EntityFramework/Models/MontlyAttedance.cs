using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MontlyAttedance
{
    public int MontlyAttedanceId { get; set; }

    public int PersonId { get; set; }

    public int PayrollPeriodId { get; set; }

    public int PayDays { get; set; }

    public int UnPayDays { get; set; }

    public int AbsenceCount { get; set; }

    public string SrattedanceInsentif { get; set; } = null!;

    public int WorkingDays { get; set; }

    public int Holidays { get; set; }

    public int OvertimeDays { get; set; }

    public int HolidayWorking { get; set; }

    public int LateDays { get; set; }

    public int EarlyLeaveDays { get; set; }

    public decimal? BasicWorkingTime { get; set; }

    public decimal? OvertimeHours { get; set; }

    public decimal? ConvertOvertimeHours { get; set; }

    public decimal? TotalWorkingTime { get; set; }

    public int? BasicFoodExspenses { get; set; }

    public int? OvertimeFoodExspenses { get; set; }

    public int? RamadhanFoodExspenses { get; set; }

    public int? Shift1Compensation { get; set; }

    public int? Shift2Compensation { get; set; }

    public int? Shift3Compensation { get; set; }

    public int? Shift4Compensation { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
