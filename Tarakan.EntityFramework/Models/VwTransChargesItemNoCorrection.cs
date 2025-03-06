using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransChargesItemNoCorrection
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ChargeClassId { get; set; }

    public string ParamedicId { get; set; }

    public string SecondParamedicId { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsVariable { get; set; }

    public bool IsCito { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public decimal StockQuantity { get; set; }

    public string SritemUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal CitoAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public string SrdiscountReason { get; set; }

    public bool? IsAssetUtilization { get; set; }

    public string AssetId { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsOrderRealization { get; set; }

    public bool IsPackage { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; }

    public string FilmNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ParentNo { get; set; }

    public string SrcenterId { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
