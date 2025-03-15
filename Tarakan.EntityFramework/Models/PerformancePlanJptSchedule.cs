using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanJptSchedule
{
    public string YearPeriod { get; set; } = null!;

    public bool? IsOpenInput { get; set; }

    public DateTime? OpenInputDateTime { get; set; }

    public string? OpenInputByUserId { get; set; }

    public bool? IsOpenRealizationQuarter1 { get; set; }

    public DateTime? OpenRealizationQuarter1DateTime { get; set; }

    public string? OpenRealizationQuarter1ByUserId { get; set; }

    public bool? IsOpenRealizationQuarter2 { get; set; }

    public DateTime? OpenRealizationQuarter2DateTime { get; set; }

    public string? OpenRealizationQuarter2ByUserId { get; set; }

    public bool? IsOpenRealizationQuarter3 { get; set; }

    public DateTime? OpenRealizationQuarter3DateTime { get; set; }

    public string? OpenRealizationQuarter3ByUserId { get; set; }

    public bool? IsOpenRealizationQuarter4 { get; set; }

    public DateTime? OpenRealizationQuarter4DateTime { get; set; }

    public string? OpenRealizationQuarter4ByUserId { get; set; }

    public bool? IsOpenVerificationQuarter1 { get; set; }

    public DateTime? OpenVerificationQuarter1DateTime { get; set; }

    public string? OpenVerificationQuarter1ByUserId { get; set; }

    public bool? IsOpenVerificationQuarter2 { get; set; }

    public DateTime? OpenVerificationQuarter2DateTime { get; set; }

    public string? OpenVerificationQuarter2ByUserId { get; set; }

    public bool? IsOpenVerificationQuarter3 { get; set; }

    public DateTime? OpenVerificationQuarter3DateTime { get; set; }

    public string? OpenVerificationQuarter3ByUserId { get; set; }

    public bool? IsOpenVerificationQuarter4 { get; set; }

    public DateTime? OpenVerificationQuarter4DateTime { get; set; }

    public string? OpenVerificationQuarter4ByUserId { get; set; }

    public bool? IsOpenValidationQuarter1 { get; set; }

    public DateTime? OpenValidationQuarter1DateTime { get; set; }

    public string? OpenValidationQuarter1ByUserId { get; set; }

    public bool? IsOpenValidationQuarter2 { get; set; }

    public DateTime? OpenValidationQuarter2DateTime { get; set; }

    public string? OpenValidationQuarter2ByUserId { get; set; }

    public bool? IsOpenValidationQuarter3 { get; set; }

    public DateTime? OpenValidationQuarter3DateTime { get; set; }

    public string? OpenValidationQuarter3ByUserId { get; set; }

    public bool? IsOpenValidationQuarter4 { get; set; }

    public DateTime? OpenValidationQuarter4DateTime { get; set; }

    public string? OpenValidationQuarter4ByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
