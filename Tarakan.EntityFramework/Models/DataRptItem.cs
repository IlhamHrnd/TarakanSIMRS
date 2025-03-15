using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DataRptItem
{
    public string SrdataRpt { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public short? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
