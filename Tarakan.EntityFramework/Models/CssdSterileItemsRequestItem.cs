using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsRequestItem
{
    public string RequestNo { get; set; } = null!;

    public string RequestSeqNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string SrcssdItemUnit { get; set; } = null!;

    public decimal Qty { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
