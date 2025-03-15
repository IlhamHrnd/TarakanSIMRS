using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DataRptMaster
{
    public string SrdataRpt { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? SeqNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
