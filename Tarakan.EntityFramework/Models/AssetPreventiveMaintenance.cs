using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetPreventiveMaintenance
{
    public string Pmno { get; set; }

    public DateTime Pmdate { get; set; }

    public string ServiceUnitId { get; set; }

    public string AssetId { get; set; }

    public string SrworkTrade { get; set; }

    public DateTime TargetDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
