using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsReturnedItem
{
    public string ReturnNo { get; set; }

    public string ReturnSeqNo { get; set; }

    public string ProcessNo { get; set; }

    public string ProcessSeqNo { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
