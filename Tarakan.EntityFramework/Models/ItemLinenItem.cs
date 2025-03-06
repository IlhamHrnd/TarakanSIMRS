using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemLinenItem
{
    public string ItemId { get; set; }

    public string ItemDetailId { get; set; }

    public decimal Qty { get; set; }

    public decimal QtyDetail { get; set; }

    public string SritemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
