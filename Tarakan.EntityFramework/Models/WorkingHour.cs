using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WorkingHour
{
    public int WorkingHourId { get; set; }

    public string? WorkingHourName { get; set; }

    public string? StartTime { get; set; }

    public string? MinimumStartTime { get; set; }

    public string? MaximumStartTime { get; set; }

    public string? EndTime { get; set; }

    public string? MinimumEndTime { get; set; }

    public string? MaximumEndTime { get; set; }

    public bool? IsOvertimeWorkingHour { get; set; }

    public int? OvertimeValueInMinutes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateUserId { get; set; }

    public int? MealQty { get; set; }

    public string? Srshift { get; set; }

    public bool? IsShiftLeader { get; set; }

    public bool? IsNotValidated { get; set; }

    public bool? IsOffDay { get; set; }

    public bool? IsCrossDay { get; set; }

    public string? StartTime2 { get; set; }

    public string? MinimumStartTime2 { get; set; }

    public string? MaximumStartTime2 { get; set; }

    public string? EndTime2 { get; set; }

    public string? MinimumEndTime2 { get; set; }

    public string? MaximumEndTime2 { get; set; }

    public bool? IsHoliday { get; set; }

    public bool? IsShiftLeader2 { get; set; }

    public bool? IsLongShift { get; set; }
}
