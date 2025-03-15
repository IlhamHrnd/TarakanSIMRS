using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentItem
{
    public string PaymentNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string SrpaymentType { get; set; } = null!;

    public string SrpaymentMethod { get; set; } = null!;

    public string? SrcardProvider { get; set; }

    public string? SrcardType { get; set; }

    public string? SrdiscountReason { get; set; }

    public string? EdcmachineId { get; set; }

    public string? CardHolderName { get; set; }

    public decimal? CardFeeAmount { get; set; }

    public string? BankId { get; set; }

    public string? ReferenceNo { get; set; }

    public decimal Amount { get; set; }

    public decimal Balance { get; set; }

    public bool IsFromDownPayment { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsPackageClosed { get; set; }

    public string? CardNo { get; set; }

    public decimal? RoundingAmount { get; set; }

    public decimal? AmountReceived { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public int? CashTransactionReconcileId { get; set; }

    public bool? IsBackOfficeReturn { get; set; }

    public int? BackOfficeReturnTransactionId { get; set; }

    public virtual TransPayment PaymentNoNavigation { get; set; } = null!;
}
