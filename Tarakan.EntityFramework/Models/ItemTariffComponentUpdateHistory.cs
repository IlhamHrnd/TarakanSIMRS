using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffComponentUpdateHistory
{
    public string RequestNo { get; set; }

    public string SrtariffType { get; set; }

    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public DateTime StartingDate { get; set; }

    public string TariffComponentId { get; set; }

    public decimal? Price { get; set; }

    public decimal? ToPrice { get; set; }

    public bool? IsAllowDiscount { get; set; }

    public bool? ToIsAllowDiscount { get; set; }

    public bool? IsAllowVariable { get; set; }

    public bool? ToIsAllowVariable { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
