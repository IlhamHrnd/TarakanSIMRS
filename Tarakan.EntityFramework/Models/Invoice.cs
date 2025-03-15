using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Invoice
{
    public string InvoiceNo { get; set; } = null!;

    public string? SrreceivableType { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public decimal? InvoiceTop { get; set; }

    public string? GuarantorId { get; set; }

    public string? SrinvoicePayment { get; set; }

    public string? BankId { get; set; }

    public string? BankAccountNo { get; set; }

    public string? InvoiceNotes { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? SrreceivableStatus { get; set; }

    public string? VoucherId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string? VerifyByUserId { get; set; }

    public string? PaymentByUserId { get; set; }

    public DateTime? AgingDate { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDate { get; set; }

    public string? PaymentApprovedByUserId { get; set; }

    public string? SrpaymentType { get; set; }

    public string? SrpaymentMethod { get; set; }

    public string? SrcardProvider { get; set; }

    public string? SrcardType { get; set; }

    public string? SrdiscountReason { get; set; }

    public string? EdcmachineId { get; set; }

    public string? CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public bool? IsInvoicePayment { get; set; }

    public string? InvoiceReferenceNo { get; set; }

    public string? Reason { get; set; }

    public bool IsWriteOff { get; set; }

    public string? PrintReceiptAsName { get; set; }

    public bool? IsAddPayment { get; set; }

    public bool? IsDiscountInPercantege { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? DiscountAmount { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? TransferNumber { get; set; }

    public bool? IsAdditionalInvoice { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public DateTime? StartPeriod { get; set; }

    public DateTime? EndPeriod { get; set; }

    public int? BkuAccountId { get; set; }

    public string? VoidReason { get; set; }
}
