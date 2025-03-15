using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InitialGlitem
{
    public string YearNo { get; set; } = null!;

    public string MonthNo { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public string SracctSubsidiary { get; set; } = null!;

    public string SubsidiaryId { get; set; } = null!;

    public string Srcurrency { get; set; } = null!;

    public decimal DebetAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal InitialRate { get; set; }

    public decimal DebetConvert { get; set; }

    public decimal CreditConvert { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
