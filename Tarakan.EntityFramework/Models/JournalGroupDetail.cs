using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalGroupDetail
{
    public int JournalDetailId { get; set; }

    public int JournalGroupId { get; set; }

    public string JournalJournalCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
