using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMaintenanceOrder
{
    public string JobOrderNo { get; set; } = null!;

    public DateTime OrderedDate { get; set; }

    public string FromServiceUnitId { get; set; } = null!;

    public string FromLocationId { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string AssetId { get; set; } = null!;

    public string RequestBy { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsPosted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
