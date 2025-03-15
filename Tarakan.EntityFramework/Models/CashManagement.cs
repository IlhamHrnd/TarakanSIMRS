using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CashManagement
{
    public string TransactionNo { get; set; } = null!;

    public DateTime OpeningDate { get; set; }

    public string Srshift { get; set; } = null!;

    public string SrcashierCounter { get; set; } = null!;

    public decimal OpeningBalance { get; set; }

    public decimal? CashPayment { get; set; }

    public decimal? CashAmount { get; set; }

    public decimal? ClosingBalance { get; set; }

    public DateTime? ClosingDate { get; set; }

    public string? ClosingByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public bool? IsVoid { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
