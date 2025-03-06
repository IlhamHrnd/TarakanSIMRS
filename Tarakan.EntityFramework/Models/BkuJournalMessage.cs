using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BkuJournalMessage
{
    public int BkuJournalMessagesId { get; set; }

    public int BkuJournalId { get; set; }

    public int DetailJournalId { get; set; }

    public string Message { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }
}
