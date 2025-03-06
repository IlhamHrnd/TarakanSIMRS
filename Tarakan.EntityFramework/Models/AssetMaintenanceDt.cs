using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMaintenanceDt
{
    public string TransactionNo { get; set; }

    public bool IsMasterItem { get; set; }

    public string ItemId { get; set; }

    public decimal Quantity { get; set; }

    public string ItemUnit { get; set; }

    public decimal ConversionFactor { get; set; }

    public string BaseItemUnit { get; set; }

    public decimal BaseQuantity { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int MaintenanceItemId { get; set; }
}
