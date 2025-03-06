using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuSetting
{
    public DateTime StartingDate { get; set; }

    public string VersionId { get; set; }

    public string SeqNo { get; set; }

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
