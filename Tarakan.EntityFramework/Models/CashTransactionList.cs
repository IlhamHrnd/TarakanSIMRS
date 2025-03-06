using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CashTransactionList
{
    public string ListId { get; set; }

    public string Description { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public string CashType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
