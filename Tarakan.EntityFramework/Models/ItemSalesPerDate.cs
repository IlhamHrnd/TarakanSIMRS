using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemSalesPerDate
{
    public DateTime MovementDate { get; set; }

    public string SrstockGroup { get; set; }

    public string ItemId { get; set; }

    public string ServiceUnitId { get; set; }

    public string LocationId { get; set; }

    public decimal QuantityOut { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
