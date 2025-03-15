using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientScheduling
{
    public string PatientId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string Srschedule { get; set; } = null!;

    public bool IsConfirmed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
