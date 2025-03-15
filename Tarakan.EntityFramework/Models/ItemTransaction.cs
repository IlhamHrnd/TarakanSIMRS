using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTransaction
{
    public string TransactionNo { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string BusinessPartnerId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public string? CurrencyId { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public DateTime ReferenceDate { get; set; }

    public string? FromServiceUnitId { get; set; }

    public string? FromLocationId { get; set; }

    public string? ToServiceUnitId { get; set; }

    public string? ToLocationId { get; set; }

    public string? TermId { get; set; }

    public string SritemType { get; set; } = null!;

    public decimal DiscountAmount { get; set; }

    public decimal ChargesAmount { get; set; }

    public decimal StampAmount { get; set; }

    public decimal DownPaymentAmount { get; set; }

    public string DownPaymentReferenceNo { get; set; } = null!;

    public string SrdownPaymentType { get; set; } = null!;

    public string SradjustmentType { get; set; } = null!;

    public string SrdistributionType { get; set; } = null!;

    public string SrpurchaseReturnType { get; set; } = null!;

    public string? SrpurchaseOrderType { get; set; }

    public decimal TaxPercentage { get; set; }

    public decimal TaxAmount { get; set; }

    public short IsTaxable { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool IsClosed { get; set; }

    public bool IsBySystem { get; set; }

    public bool? IsNonMasterOrder { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? ProductAccountId { get; set; }

    public string? LeadTime { get; set; }

    public decimal? Pph22 { get; set; }

    public decimal? Pph23 { get; set; }

    public string? ContractNo { get; set; }

    public decimal? PriorChargesAmount { get; set; }

    public decimal? PriorTaxAmount { get; set; }

    public string? CustomerId { get; set; }

    public string? TaxInvoiceNo { get; set; }

    public DateTime? TaxInvoiceDate { get; set; }

    public string? SrpaymentType { get; set; }

    public string? SrpurchaseCategorization { get; set; }

    public bool? IsInventoryItem { get; set; }

    public decimal? TermOfPayment { get; set; }

    public bool? IsAssets { get; set; }

    public int? BudgetPlanCounter { get; set; }

    public string? ServiceUnitCostId { get; set; }

    public bool? IsPph22InPercent { get; set; }

    public decimal? Pph22Percentage { get; set; }

    public bool? IsPph23InPercent { get; set; }

    public decimal? Pph23Percentage { get; set; }

    public bool? IsConsignment { get; set; }

    public decimal? AmountTaxed { get; set; }

    public short? RevisionNumber { get; set; }

    public short? PrintNumber { get; set; }

    public DateTime? LastPrintedDateTime { get; set; }

    public string? LastPrintedByUserId { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public string? DeliveryOrdersNo { get; set; }

    public DateTime? DeliveryOrdersDate { get; set; }

    public decimal? PphAmount { get; set; }

    public DateTime? InvoiceSupplierDate { get; set; }

    public string? CashTransactionReconcileId { get; set; }

    public string? ItemGroupId { get; set; }

    public string? Srpph { get; set; }

    public decimal? PphPercentage { get; set; }

    public bool? IsConsignmentAlreadyReceived { get; set; }

    public DateTime? PlanningDate { get; set; }

    public bool? IsInstallmentType { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public string? SritemCategory { get; set; }

    public string? SrprocurementType { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? CheckNo { get; set; }

    public DateTime? CheckDate { get; set; }

    public decimal? SalesMarginPercentage { get; set; }

    public bool? IsCito { get; set; }

    public virtual ICollection<ItemTransactionItem> ItemTransactionItems { get; set; } = new List<ItemTransactionItem>();
}
