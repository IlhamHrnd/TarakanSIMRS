using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorInfoSummary
{
    public string GuarantorId { get; set; }

    public int? NoteCount { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
