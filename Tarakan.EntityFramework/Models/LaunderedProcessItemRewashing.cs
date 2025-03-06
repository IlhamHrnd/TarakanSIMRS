using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaunderedProcessItemRewashing
{
    public string ProcessNo { get; set; }

    public string ProcessSeqNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public string ReferenceNo { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
