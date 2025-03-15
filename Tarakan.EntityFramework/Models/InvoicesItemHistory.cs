using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoicesItemHistory
{
    public string InvoiceNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PatientId { get; set; }

    public string? PatientName { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? Notes { get; set; }

    public decimal? Amount { get; set; }

    public decimal? VerifyAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
