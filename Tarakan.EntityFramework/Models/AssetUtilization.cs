using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetUtilization
{
    public string AssetId { get; set; }

    public string PeriodNo { get; set; }

    public short UsageCounter { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
