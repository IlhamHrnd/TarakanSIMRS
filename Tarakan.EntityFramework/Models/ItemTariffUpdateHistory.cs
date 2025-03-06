using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffUpdateHistory
{
    public string RequestNo { get; set; }

    public string SrtariffType { get; set; }

    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public DateTime StartingDate { get; set; }

    public decimal? Price { get; set; }

    public decimal? ToPrice { get; set; }

    public decimal? DiscPercentage { get; set; }

    public decimal? ToDiscPercentage { get; set; }

    public bool? IsAdminCalculation { get; set; }

    public bool? ToIsAdminCalculation { get; set; }

    public bool? IsAllowDiscount { get; set; }

    public bool? ToIsAllowDiscount { get; set; }

    public bool? IsAllowVariable { get; set; }

    public bool? ToIsAllowVariable { get; set; }

    public bool? IsAllowCito { get; set; }

    public bool? ToIsAllowCito { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public bool? ToIsCitoInPercent { get; set; }

    public decimal? CitoValue { get; set; }

    public decimal? ToCitoValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }

    public bool? ToIsCitoFromStandardReference { get; set; }
}
