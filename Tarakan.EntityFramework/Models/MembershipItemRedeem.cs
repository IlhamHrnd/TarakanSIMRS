using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MembershipItemRedeem
{
    public string ItemReedemId { get; set; } = null!;

    public string ItemReedemName { get; set; } = null!;

    public string SritemReedemGroup { get; set; } = null!;

    public decimal? PointsUsed { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
