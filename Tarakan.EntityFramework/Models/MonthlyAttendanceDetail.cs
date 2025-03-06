using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MonthlyAttendanceDetail
{
    public long MonthlyAttendanceDetailId { get; set; }

    public int PersonId { get; set; }

    public int PayrollPeriodId { get; set; }

    public DateTime ScheduleInDate { get; set; }

    public string ScheduleInTime { get; set; }

    public DateTime? ScheduleOutDate { get; set; }

    public string ScheduleOutTime { get; set; }

    public DateTime? CheckInDate { get; set; }

    public string CheckInTime { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public string CheckOutTime { get; set; }

    public bool? IsOvertime { get; set; }

    public decimal? OvertimeHours { get; set; }

    public short? LateMinutes { get; set; }

    public decimal? LateCutPercentage { get; set; }

    public short? EarlyLeaveMinutes { get; set; }

    public decimal? EarlyLeaveCutPercentage { get; set; }

    public bool? IsInvalid { get; set; }

    public bool? IsHasPermission { get; set; }

    public string SrattendanceFileFormat { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsOff { get; set; }

    public bool? IsPayCut { get; set; }

    public decimal? CutAmount { get; set; }
}
