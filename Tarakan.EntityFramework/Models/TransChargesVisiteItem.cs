using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesVisiteItem
{
    public string TransactionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public int VisiteQty { get; set; }

    public int RealizationQty { get; set; }

    public bool? IsClosed { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedDateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
