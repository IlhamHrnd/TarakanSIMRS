using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicGlobalSchedule
{
    public string ParamedicId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public int DayOfWeek { get; set; }

    public string OperationalTimeId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
