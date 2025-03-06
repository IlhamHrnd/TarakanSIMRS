using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ThrSchedule
{
    public int CounterId { get; set; }

    public int PayrollPeriodId { get; set; }

    public string PayrollPeriodName { get; set; }

    public DateTime? PayDate { get; set; }

    public int? Sptyear { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
