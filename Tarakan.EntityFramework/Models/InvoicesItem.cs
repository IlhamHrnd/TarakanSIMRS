using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvoicesItem
{
    public string InvoiceNo { get; set; } = null!;

    public string PaymentNo { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PatientId { get; set; }

    public string? PatientName { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? Notes { get; set; }

    public string? AccountId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? VerifyAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? OtherAmount { get; set; }

    public string InvoiceReferenceNo { get; set; } = null!;

    public decimal? BankCost { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubLedgerId { get; set; }

    public string? SrdiscountReason { get; set; }

    public bool? IsDiscountInPercent { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? PpnAmount { get; set; }

    public decimal? PphAmount { get; set; }

    public bool? IsPpn { get; set; }

    public decimal? PpnPercentage { get; set; }

    public bool? IsPph { get; set; }

    public string? Srpph { get; set; }

    public decimal? PphPercentage { get; set; }

    public decimal? ClaimDifferenceAmount { get; set; }
}
