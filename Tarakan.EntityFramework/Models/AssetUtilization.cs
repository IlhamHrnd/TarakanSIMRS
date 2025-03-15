using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetUtilization
{
    public string AssetId { get; set; } = null!;

    public string PeriodNo { get; set; } = null!;

    public short UsageCounter { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
