using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetStatusHistory
{
    public int SeqNo { get; set; }

    public string AssetId { get; set; } = null!;

    public string SrassetsStatusFrom { get; set; } = null!;

    public string SrassetsStatusTo { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsFixedAssetFrom { get; set; }

    public bool? IsFixedAssetTo { get; set; }

    public decimal? CurrentValue { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? BuyersName { get; set; }

    public string? BuyersAddress { get; set; }

    public string? BuyersPhoneNo { get; set; }

    public string? BuyersTaxRegister { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public decimal? DepreciationAccValue { get; set; }

    public decimal? SalesPrice { get; set; }

    public string? TaxStatus { get; set; }

    public decimal? TaxPercentage { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? SrpaymentType { get; set; }

    public string? SrpaymentMethod { get; set; }

    public string? BankId { get; set; }
}
