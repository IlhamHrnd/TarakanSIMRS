using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanNonJptTxItem
{
    public long TxItemId { get; set; }

    public long TxId { get; set; }

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

    public decimal? RevisionQuarter1 { get; set; }

    public decimal? RevisionQuarter2 { get; set; }

    public decimal? RevisionQuarter3 { get; set; }

    public decimal? RevisionQuarter4 { get; set; }

    public decimal? RevisionYearTarget { get; set; }

    public decimal? RealizationQuarter1 { get; set; }

    public decimal? RealizationQuarter2 { get; set; }

    public decimal? RealizationQuarter3 { get; set; }

    public decimal? RealizationQuarter4 { get; set; }

    public decimal? RealizationYearTarget { get; set; }

    public string? RealizationNotesQuarter1 { get; set; }

    public string? RealizationNotesQuarter2 { get; set; }

    public string? RealizationNotesQuarter3 { get; set; }

    public string? RealizationNotesQuarter4 { get; set; }

    public decimal? ValidationQuarter1 { get; set; }

    public decimal? ValidationQuarter2 { get; set; }

    public decimal? ValidationQuarter3 { get; set; }

    public decimal? ValidationQuarter4 { get; set; }

    public decimal? ValidationYearTarget { get; set; }

    public string? ValidationNotesQuarter1 { get; set; }

    public string? ValidationNotesQuarter2 { get; set; }

    public string? ValidationNotesQuarter3 { get; set; }

    public string? ValidationNotesQuarter4 { get; set; }

    public decimal? AchievementsYearTarget { get; set; }

    public bool? IsAdditional { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public bool? IsRealizationQuarter1 { get; set; }

    public DateTime? RealizationQuarter1DateTime { get; set; }

    public string? RealizationQuarter1ByUserId { get; set; }

    public bool? IsRealizationQuarter2 { get; set; }

    public DateTime? RealizationQuarter2DateTime { get; set; }

    public string? RealizationQuarter2ByUserId { get; set; }

    public bool? IsRealizationQuarter3 { get; set; }

    public DateTime? RealizationQuarter3DateTime { get; set; }

    public string? RealizationQuarter3ByUserId { get; set; }

    public bool? IsRealizationQuarter4 { get; set; }

    public DateTime? RealizationQuarter4DateTime { get; set; }

    public string? RealizationQuarter4ByUserId { get; set; }

    public bool? IsValidationQuarter1 { get; set; }

    public DateTime? ValidationQuarter1DateTime { get; set; }

    public string? ValidationQuarter1ByUserId { get; set; }

    public bool? IsValidationQuarter2 { get; set; }

    public DateTime? ValidationQuarter2DateTime { get; set; }

    public string? ValidationQuarter2ByUserId { get; set; }

    public DateTime? ValidationQuarter3DateTime { get; set; }

    public bool? IsValidationQuarter3 { get; set; }

    public string? ValidationQuarter3ByUserId { get; set; }

    public bool? IsValidationQuarter4 { get; set; }

    public DateTime? ValidationQuarter4DateTime { get; set; }

    public string? ValidationQuarter4ByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
