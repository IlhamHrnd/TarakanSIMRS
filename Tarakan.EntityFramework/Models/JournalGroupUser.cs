using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalGroupUser
{
    public int JournalUserId { get; set; }

    public int JournalGroupId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
