using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CashTransactionDetail
{
    public int DetailId { get; set; }

    public int TransactionId { get; set; }

    public int ChartOfAccountId { get; set; }

    public int SubLedgerId { get; set; }

    public int CostCenterId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public decimal Amount { get; set; }

    public string Description { get; set; }

    public string ListId { get; set; }

    public bool? IsParentRefference { get; set; }

    public string ReferenceNo { get; set; }

    public virtual CashTransaction Transaction { get; set; }
}
