using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryDistribution
{
    public string DistributionNo { get; set; } = null!;

    public DateTime DistributionDate { get; set; }

    public string DistributionTime { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string HandedByUserId { get; set; } = null!;

    public string ReceivedBy { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
