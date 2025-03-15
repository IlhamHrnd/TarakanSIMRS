using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetPreventiveMaintenanceSchedulePeriodDate
{
    public string AssetId { get; set; } = null!;

    public string PeriodYear { get; set; } = null!;

    public DateTime PeriodDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
