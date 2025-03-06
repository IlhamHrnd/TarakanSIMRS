using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTransactionItem
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal QuantityFinishInBaseUnit { get; set; }

    public int? PageNo { get; set; }

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal PriceInCurrency { get; set; }

    public decimal Discount1Percentage { get; set; }

    public decimal Discount2Percentage { get; set; }

    public string BatchNumber { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public bool IsPackage { get; set; }

    public bool IsBonusItem { get; set; }

    public bool IsClosed { get; set; }

    public string Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? RequestQty { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountInCurrency { get; set; }

    public bool? IsDiscountInPercent { get; set; }

    public bool? IsInvoiceUpdate { get; set; }

    public decimal? PriorPrice { get; set; }

    public decimal? PriorPriceInCurrency { get; set; }

    public decimal? PriorDiscount1Percentage { get; set; }

    public decimal? PriorDiscount2Percentage { get; set; }

    public decimal? PriorDiscount { get; set; }

    public decimal? PriorDiscountInCurrency { get; set; }

    public DateTime? LastInvoiceUpdateDateTime { get; set; }

    public string LastInvoiceUpdateByUserId { get; set; }

    public decimal? HistoryPrice { get; set; }

    public decimal? HistoryPriceInCurrency { get; set; }

    public decimal? HistoryDiscount1Percentage { get; set; }

    public decimal? HistoryDiscount2Percentage { get; set; }

    public decimal? HistoryDiscount { get; set; }

    public decimal? HistoryDiscountInCurrency { get; set; }

    public string Specification { get; set; }

    public bool? IsAccEd { get; set; }

    public bool? IsAccPrice { get; set; }

    public bool? IsAccQty { get; set; }

    public bool? IsTaxable { get; set; }

    public bool? IsTaxablePph { get; set; }

    public string Srpph { get; set; }

    public decimal? PphPercentage { get; set; }

    public decimal? PphAmount { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string Note { get; set; }

    public virtual ItemTransaction TransactionNoNavigation { get; set; }
}
