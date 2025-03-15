using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitSchedule
{
    public string ServiceUnitId { get; set; } = null!;

    public int DayOfWeek { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
