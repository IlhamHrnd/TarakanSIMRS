using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MembershipDetail
{
    public long MembershipDetailId { get; set; }

    public string MembershipNo { get; set; } = null!;

    public string? RegistrationNo { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? ReedeemAmount { get; set; }

    public decimal? BalanceAmount { get; set; }

    public decimal? RewardPoint { get; set; }

    public decimal? RewardPointRefferal { get; set; }

    public decimal? ClaimedPoint { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
