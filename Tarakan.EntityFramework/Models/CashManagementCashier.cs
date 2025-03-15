using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CashManagementCashier
{
    public string TransactionNo { get; set; } = null!;

    public string CashierUserId { get; set; } = null!;

    public bool? IsCashierCheckin { get; set; }

    public DateTime? CashierCheckinDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
