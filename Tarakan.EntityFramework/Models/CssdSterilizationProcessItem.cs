using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterilizationProcessItem
{
    public string ProcessNo { get; set; } = null!;

    public string ProcessSeqNo { get; set; } = null!;

    public string ReceivedNo { get; set; } = null!;

    public string ReceivedSeqNo { get; set; } = null!;

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
