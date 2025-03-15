using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBalance
{
    public string LocationId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ReorderType { get; set; } = null!;

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public decimal Balance { get; set; }

    public decimal Booking { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SritemBin { get; set; }

    public string? ItemSubBin { get; set; }
}
