using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitProductAccountMapping
{
    public string LocationId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ProductAccountId { get; set; }

    public string SrregistrationType { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdAccrual { get; set; }

    public int? SubledgerIdAccrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public int? ChartOfAccountIdInventory { get; set; }

    public int? SubledgerIdInventory { get; set; }

    public int? ChartOfAccountIdCogs { get; set; }

    public int? SubledgerIdCogs { get; set; }

    public int? ChartOfAccountIdExpense { get; set; }

    public int? SubledgerIdExpense { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
