using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemStockOpnameApproval
{
    public string TransactionNo { get; set; } = null!;

    public int PageNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }
}
