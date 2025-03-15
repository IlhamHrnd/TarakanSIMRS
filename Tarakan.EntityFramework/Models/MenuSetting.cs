using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuSetting
{
    public DateTime StartingDate { get; set; }

    public string VersionId { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
