using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BkuJournalTransactionDetail
{
    public int BkuDetailId { get; set; }

    public int BkuJournalId { get; set; }

    public int JournalDetailIdToCopy { get; set; }

    public int ChartOfAccountId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Description { get; set; } = null!;

    public int SubLedgerId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
