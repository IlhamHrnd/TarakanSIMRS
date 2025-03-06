using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetInventoriedHistory
{
    public string AssetId { get; set; }

    public string SequenceNo { get; set; }

    public DateTime InventoriedDate { get; set; }

    public string InventoriedBy { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
