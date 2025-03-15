using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QualityIndicatorSurvey
{
    public int SurveyId { get; set; }

    public string StandardReferenceId { get; set; } = null!;

    public DateOnly PeriodDate { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool IsApprove { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public bool IsVoid { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidNotes { get; set; }

    public string ServiceUnitId { get; set; } = null!;
}
