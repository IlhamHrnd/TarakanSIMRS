using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanActivity
{
    public long ActivityId { get; set; }

    public int PersonId { get; set; }

    public DateTime ActivityDate { get; set; }

    public string StartTime { get; set; } = null!;

    public string? EndTime { get; set; }

    public string? SractivityCategory { get; set; }

    public string? WorkPlanIndicators { get; set; }

    public string? Activity { get; set; }

    public decimal? EffectiveTime { get; set; }

    public decimal? Volume { get; set; }

    public string? Notes { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public string? DeletedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsRejected { get; set; }

    public DateTime? RejectedDateTime { get; set; }

    public string? RejectedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
