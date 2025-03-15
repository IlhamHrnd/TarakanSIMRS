using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffComponentUpdateHistory
{
    public string RequestNo { get; set; } = null!;

    public string SrtariffType { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string TariffComponentId { get; set; } = null!;

    public decimal? Price { get; set; }

    public decimal? ToPrice { get; set; }

    public bool? IsAllowDiscount { get; set; }

    public bool? ToIsAllowDiscount { get; set; }

    public bool? IsAllowVariable { get; set; }

    public bool? ToIsAllowVariable { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
