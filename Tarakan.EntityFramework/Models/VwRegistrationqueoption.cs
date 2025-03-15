using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrationqueoption
{
    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string StartTime1 { get; set; } = null!;

    public string EndTime1 { get; set; } = null!;

    public string StartTime2 { get; set; } = null!;

    public string EndTime2 { get; set; } = null!;

    public string StartTime3 { get; set; } = null!;

    public string EndTime3 { get; set; } = null!;

    public string StartTime4 { get; set; } = null!;

    public string EndTime4 { get; set; } = null!;

    public string StartTime5 { get; set; } = null!;

    public string EndTime5 { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;
}
