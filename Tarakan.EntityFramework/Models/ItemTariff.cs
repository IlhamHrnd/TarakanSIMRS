using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariff
{
    public string SrtariffType { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public decimal Price { get; set; }

    public bool? IsAdminCalculation { get; set; }

    /// <summary>
    /// Setting untuk item yg tarifnya tidak di rinci
    /// </summary>
    public bool? IsAllowDiscount { get; set; }

    /// <summary>
    /// Setting untuk item yg tarifnya tidak di rinci
    /// </summary>
    public bool? IsAllowVariable { get; set; }

    public bool? IsAllowCito { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? CitoValue { get; set; }

    /// <summary>
    /// Update from TransactionNo
    /// </summary>
    public string? ReferenceNo { get; set; }

    public string? ReferenceTransactionCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public decimal? DiscPercentage { get; set; }

    public bool? IsCitoFromStandardReference { get; set; }

    public decimal? Ppn { get; set; }
}
