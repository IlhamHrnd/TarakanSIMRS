using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoiceSupplierItem
{
    public string InvoiceNo { get; set; }

    public string TransactionNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? VerifyAmount { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string Notes { get; set; }

    public string AccountId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string VoucherId { get; set; }

    public DateTime? AgingDate { get; set; }

    public string SrinvoicePayment { get; set; }

    public string BankId { get; set; }

    public string BankAccountNo { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string VerifyByUserId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string PaymentByUserId { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDate { get; set; }

    public string PaymentApprovedByUserId { get; set; }

    public decimal? PpnAmount { get; set; }

    public decimal? Pph22Amount { get; set; }

    public decimal? Pph23Amount { get; set; }

    public string CurrencyId { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? StampAmount { get; set; }

    public string InvoiceReferenceNo { get; set; }

    public string InvoiceSn { get; set; }

    public DateTime? TaxInvoiceDate { get; set; }

    public decimal? OtherDeduction { get; set; }

    public bool? IsAdditionalInvoice { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubLedgerId { get; set; }

    public decimal? DownPaymentAmount { get; set; }

    public string Srpph { get; set; }

    public decimal? PphPercentage { get; set; }

    public decimal? PphAmount { get; set; }

    public string SritemType { get; set; }

    public bool? IsPpnExcluded { get; set; }
}
