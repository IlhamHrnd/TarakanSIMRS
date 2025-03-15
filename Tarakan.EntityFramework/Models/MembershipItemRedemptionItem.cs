using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MembershipItemRedemptionItem
{
    public string TransactionNo { get; set; } = null!;

    public string ItemReedemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal PointsUsed { get; set; }

    public decimal TotalPointsUsed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
