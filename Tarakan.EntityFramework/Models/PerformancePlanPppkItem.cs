using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanPppkItem
{
    public int PerformancePlanItemId { get; set; }

    public int PerformancePlanId { get; set; }

    public string PerformancePlanNo { get; set; } = null!;

    public string Activity { get; set; } = null!;

    public string? UnitTargets { get; set; }

    public int? Time { get; set; }

    public string? SrachievementFormula { get; set; }

    public string? SrrealizationFormula { get; set; }

    public decimal? Month01 { get; set; }

    public decimal? Month02 { get; set; }

    public decimal? Month03 { get; set; }

    public decimal? Month04 { get; set; }

    public decimal? Month05 { get; set; }

    public decimal? Month06 { get; set; }

    public decimal? Month07 { get; set; }

    public decimal? Month08 { get; set; }

    public decimal? Month09 { get; set; }

    public decimal? Month10 { get; set; }

    public decimal? Month11 { get; set; }

    public decimal? Month12 { get; set; }

    public decimal? YearTarget { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
