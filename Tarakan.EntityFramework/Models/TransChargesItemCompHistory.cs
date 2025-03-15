using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemCompHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string? ParamedicId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsPackage { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
