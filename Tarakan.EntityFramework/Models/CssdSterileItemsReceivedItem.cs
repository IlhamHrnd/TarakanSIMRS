using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsReceivedItem
{
    public string ReceivedNo { get; set; }

    public string ReceivedSeqNo { get; set; }

    public string ItemId { get; set; }

    public string SrcssdItemUnit { get; set; }

    public decimal Qty { get; set; }

    public string Notes { get; set; }

    public string CssdItemNo { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public short? ReuseTo { get; set; }

    public bool? IsNeedUltrasound { get; set; }

    public bool? IsDtt { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
