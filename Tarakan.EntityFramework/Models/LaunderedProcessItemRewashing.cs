using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaunderedProcessItemRewashing
{
    public string ProcessNo { get; set; } = null!;

    public string ProcessSeqNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public string? ReferenceNo { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
