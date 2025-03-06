using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BkuTransactionBalance
{
    public int BalanceId { get; set; }

    public int RekeningId { get; set; }

    public DateTime Date { get; set; }

    public decimal InitialBalance { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal FinalBalance { get; set; }
}
