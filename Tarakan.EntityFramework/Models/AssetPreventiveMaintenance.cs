using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetPreventiveMaintenance
{
    public string Pmno { get; set; } = null!;

    public DateTime Pmdate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string AssetId { get; set; } = null!;

    public string SrworkTrade { get; set; } = null!;

    public DateTime TargetDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
