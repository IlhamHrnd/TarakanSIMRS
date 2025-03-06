using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsRequestItem
{
    public string RequestNo { get; set; }

    public string RequestSeqNo { get; set; }

    public string ItemId { get; set; }

    public string SrcssdItemUnit { get; set; }

    public decimal Qty { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
