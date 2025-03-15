using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalRecruitmentTest
{
    public int PersonalRecruitmentTestId { get; set; }

    public int PersonId { get; set; }

    public DateTime TestDate { get; set; }

    public string SrrecruitmentTest { get; set; } = null!;

    public string TestResult { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Advantages { get; set; }

    public string? Deficiency { get; set; }

    public string? Suggestion { get; set; }

    public string? SrrecruitmentTestConclusion { get; set; }
}
