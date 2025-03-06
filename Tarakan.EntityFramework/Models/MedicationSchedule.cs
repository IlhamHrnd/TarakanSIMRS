using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationSchedule
{
    public long MedicationReceiveNo { get; set; }

    public DateTime ScheduleStartDate { get; set; }

    public int ScheduleNo { get; set; }

    public DateTime ScheduleTime { get; set; }

    public decimal Qty { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
