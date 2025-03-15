using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BkuJournalTransaction
{
    public int BkuJournalId { get; set; }

    public int CashTransactionId { get; set; }

    public int JournalIdToCopy { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
