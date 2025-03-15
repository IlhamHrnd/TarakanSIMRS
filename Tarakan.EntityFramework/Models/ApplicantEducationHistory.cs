using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantEducationHistory
{
    public int ApplicantEducationHistoryId { get; set; }

    public int ApplicantId { get; set; }

    public string SreducationLevel { get; set; } = null!;

    public string InstitutionName { get; set; } = null!;

    public string? Location { get; set; }

    public string? StartYear { get; set; }

    public string? EndYear { get; set; }

    public decimal? Gpa { get; set; }

    public string? Achievement { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
