using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTransChargesItemCompSettled
{
    public string PaymentNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public bool IsFromAr { get; set; }

    public bool IsReturn { get; set; }

    public bool IsOrderRealization { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal? FeeAmount { get; set; }

    public bool? IsRefferal { get; set; }

    public bool? IsCalculatedInPercent { get; set; }

    public decimal? CalculatedAmount { get; set; }

    public bool? IsFree { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }

    public string? LastCalculatedByUserId { get; set; }

    public string? VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsCalcDeductionInPercent { get; set; }

    public decimal? CalcDeductionAmount { get; set; }

    public decimal? DeductionAmount { get; set; }

    public int? JournalId { get; set; }
}
