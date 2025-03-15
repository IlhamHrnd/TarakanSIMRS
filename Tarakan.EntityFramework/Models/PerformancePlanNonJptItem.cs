using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanNonJptItem
{
    public int PerformancePlanItemId { get; set; }

    public int PerformancePlanId { get; set; }

    public string PerformancePlanNo { get; set; } = null!;

    public string Activity { get; set; } = null!;

    public string SrperformancePlanActivityType { get; set; } = null!;

    public string UnitTargets { get; set; } = null!;

    public string SrachievementFormula { get; set; } = null!;

    public string SrrealizationFormula { get; set; } = null!;

    public decimal Quarter1 { get; set; }

    public decimal Quarter2 { get; set; }

    public decimal Quarter3 { get; set; }

    public decimal Quarter4 { get; set; }

    public decimal YearTarget { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
