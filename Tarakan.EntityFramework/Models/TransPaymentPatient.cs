using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentPatient
{
    public string PaymentNo { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string? ReferenceNo { get; set; }

    public DateTime PaymentDate { get; set; }

    public string PaymentTime { get; set; } = null!;

    public bool IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? CashManagementNo { get; set; }

    public string? SrpatientDepositType { get; set; }
}
