using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageTransactionItem
{
    public long WageTransactionItemId { get; set; }

    public long WageTransactionId { get; set; }

    public int SalaryComponentId { get; set; }

    public decimal Qty { get; set; }

    public decimal NominalAmount { get; set; }

    public string SrcurrencyCode { get; set; } = null!;

    public decimal CurrencyRate { get; set; }

    public decimal CurrencyAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsModified { get; set; }
}
