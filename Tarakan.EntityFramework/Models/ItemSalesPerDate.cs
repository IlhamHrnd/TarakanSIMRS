using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemSalesPerDate
{
    public DateTime MovementDate { get; set; }

    public string SrstockGroup { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public decimal QuantityOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
