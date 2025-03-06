using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetPreventiveMaintenanceSchedulePeriod
{
    public string AssetId { get; set; }

    public string PeriodYear { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
