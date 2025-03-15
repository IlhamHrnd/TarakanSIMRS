using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MembershipItemRedemptionDetail
{
    public string TransactionNo { get; set; } = null!;

    public long MembershipDetailId { get; set; }

    public decimal ClaimedPoint { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
