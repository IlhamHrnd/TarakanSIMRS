using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpPaymentGdbaru
{
    public string? PaymentNo { get; set; }

    public string? Notes { get; set; }

    public string? RegistrationNo { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? Createdby { get; set; }

    public string? GuarantorId { get; set; }

    public string? TransactionCode { get; set; }

    public string? PaymentReferenceNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public DateTime? StampTime { get; set; }
}
