using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InitialGl
{
    public string YearNo { get; set; }

    public string MonthNo { get; set; }

    public string AccountId { get; set; }

    public string SracctLevel { get; set; }

    public string SracctSubsidiary { get; set; }

    public string Srcurrency { get; set; }

    public decimal DebetAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal InitialRate { get; set; }

    public decimal DebetConvert { get; set; }

    public decimal CreditConvert { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
