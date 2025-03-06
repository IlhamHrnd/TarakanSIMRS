using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMaintenanceOrder
{
    public string JobOrderNo { get; set; }

    public DateTime OrderedDate { get; set; }

    public string FromServiceUnitId { get; set; }

    public string FromLocationId { get; set; }

    public string ToServiceUnitId { get; set; }

    public string AssetId { get; set; }

    public string RequestBy { get; set; }

    public DateTime RequestDate { get; set; }

    public string Notes { get; set; }

    public bool IsPosted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
