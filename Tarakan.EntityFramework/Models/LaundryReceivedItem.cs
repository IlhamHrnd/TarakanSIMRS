using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryReceivedItem
{
    public string ReceivedNo { get; set; }

    public string ReceivedSeqNo { get; set; }

    public string ItemId { get; set; }

    public string SritemUnit { get; set; }

    public decimal Qty { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
