using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMaintenanceHd
{
    public string TransactionNo { get; set; }

    public DateTime MaintenanceDate { get; set; }

    public string JobOrderNo { get; set; }

    public string AssetId { get; set; }

    public string SrmaintenanceType { get; set; }

    public string MaintenanceBy { get; set; }

    public decimal Condition { get; set; }

    public string Notes { get; set; }

    public DateTime NextMaintenanceDate { get; set; }

    public bool IsPosted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
