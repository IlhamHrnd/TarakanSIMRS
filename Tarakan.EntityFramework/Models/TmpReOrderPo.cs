using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpReOrderPo
{
    public string UserId { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public string SupplierId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal? Quantity { get; set; }
}
