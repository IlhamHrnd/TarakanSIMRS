using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoiceSupplier
{
    public string InvoiceNo { get; set; }

    public string InvoiceSuppNo { get; set; }

    public string SupplierId { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public decimal? InvoiceTop { get; set; }

    public string InvoiceNotes { get; set; }

    public string SrpayableStatus { get; set; }

    public string VoucherId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrinvoicePayment { get; set; }

    public string BankId { get; set; }

    public string BankAccountNo { get; set; }

    public DateTime? VerifyDate { get; set; }

    public string VerifyByUserId { get; set; }

    public bool? IsInvoicePayment { get; set; }

    public string InvoiceReferenceNo { get; set; }

    public bool? IsPaymentApproved { get; set; }

    public DateTime? PaymentApprovedDateTime { get; set; }

    public string PaymentApprovedByUserId { get; set; }

    public bool? IsConsignment { get; set; }

    public bool IsWriteOff { get; set; }

    public string Reason { get; set; }

    public bool? IsAddPayment { get; set; }

    public DateTime? InvoiceReceivedDate { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public DateTime? InvoicePaymentPlanDate { get; set; }

    public string PaymentOrderNo { get; set; }

    public int? BkuAccountId { get; set; }
}
