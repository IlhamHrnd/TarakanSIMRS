using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemPackageTariffComponent
{
    public string ItemId { get; set; } = null!;

    public string DetailItemId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? Discount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
