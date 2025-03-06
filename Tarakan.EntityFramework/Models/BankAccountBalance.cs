using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BankAccountBalance
{
    public int BalanceId { get; set; }

    public string BankId { get; set; }

    public string Month { get; set; }

    public string Year { get; set; }

    public decimal InitialBalance { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal FinalBalance { get; set; }

    public virtual Bank Bank { get; set; }
}
