using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductConsumeUnitMatrix
{
    public string ItemId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string SrconsumeUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
