using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SnackOrderItem
{
    public string SnackOrderNo { get; set; } = null!;

    public string SnackId { get; set; } = null!;

    public decimal QtyShift1 { get; set; }

    public decimal QtyShift2 { get; set; }

    public decimal QtyShift3 { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
