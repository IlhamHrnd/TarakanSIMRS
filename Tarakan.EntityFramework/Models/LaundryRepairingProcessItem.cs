using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryRepairingProcessItem
{
    public string TransactionNo { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
