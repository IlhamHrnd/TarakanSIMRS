using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundrySortingProcessItem
{
    public string TransactionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
