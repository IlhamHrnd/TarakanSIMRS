using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EventMealOrderItem
{
    public string OrderNo { get; set; }

    public string FoodId { get; set; }

    public short Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
