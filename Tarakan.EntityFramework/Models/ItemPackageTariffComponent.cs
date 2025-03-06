using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemPackageTariffComponent
{
    public string ItemId { get; set; }

    public string DetailItemId { get; set; }

    public string TariffComponentId { get; set; }

    public decimal Price { get; set; }

    public decimal? Discount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
