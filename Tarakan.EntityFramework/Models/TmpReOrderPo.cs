using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpReOrderPo
{
    public string UserId { get; set; }

    public DateTime TransDate { get; set; }

    public string SupplierId { get; set; }

    public string ItemId { get; set; }

    public decimal? Quantity { get; set; }
}
