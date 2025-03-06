using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetPreventiveMaintenanceSchedule
{
    public string AssetId { get; set; }

    public DateTime ScheduleDate { get; set; }

    public string PeriodYear { get; set; }

    public DateTime PeriodDate { get; set; }

    public bool IsProcessed { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
