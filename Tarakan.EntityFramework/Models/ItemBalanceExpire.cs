using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemBalanceExpire
{
    public string LocationId { get; set; }

    public string ItemId { get; set; }

    public DateTime ExpiredDate { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
