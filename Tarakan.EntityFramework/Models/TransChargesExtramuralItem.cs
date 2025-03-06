using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesExtramuralItem
{
    public long Id { get; set; }

    public string TransactionNo { get; set; }

    public string SrextramuralItem { get; set; }

    public decimal Qty { get; set; }

    public int LeasingPeriodInDays { get; set; }

    public bool IsReturned { get; set; }

    public DateTime? ReturnDate { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? GuarantyAmount { get; set; }
}
