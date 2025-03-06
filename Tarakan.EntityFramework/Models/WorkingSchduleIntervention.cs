using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WorkingSchduleIntervention
{
    public int WorkingSchduleInterventionId { get; set; }

    public int? WorkingScheduleId { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateUserId { get; set; }
}
