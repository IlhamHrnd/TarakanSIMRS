using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PettyCash
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SrpettyCashUnitId { get; set; } = null!;

    public string? BankId { get; set; }

    public string Notes { get; set; } = null!;

    public decimal? TotalDebitAmount { get; set; }

    public decimal? TotalCreditAmount { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
