using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentPatient
{
    public string PaymentNo { get; set; }

    public string TransactionCode { get; set; }

    public string PatientId { get; set; }

    public string ReferenceNo { get; set; }

    public DateTime PaymentDate { get; set; }

    public string PaymentTime { get; set; }

    public bool IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string CashManagementNo { get; set; }

    public string SrpatientDepositType { get; set; }
}
