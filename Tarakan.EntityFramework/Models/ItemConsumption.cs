using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemConsumption
{
    public string ItemId { get; set; }

    public string DetailItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
