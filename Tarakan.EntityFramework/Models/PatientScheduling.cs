using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientScheduling
{
    public string PatientId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public DateTime ScheduleDate { get; set; }

    public string Srschedule { get; set; }

    public bool IsConfirmed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
