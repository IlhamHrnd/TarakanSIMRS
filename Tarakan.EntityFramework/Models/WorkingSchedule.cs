using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WorkingSchedule
{
    public int WorkingScheduleId { get; set; }

    public int? PayrollPeriodId { get; set; }

    public int? OrganizationUnitId { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateUserId { get; set; }
}
