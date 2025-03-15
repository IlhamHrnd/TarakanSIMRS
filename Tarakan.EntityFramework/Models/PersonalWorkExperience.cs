using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalWorkExperience
{
    public int PersonalWorkExperienceId { get; set; }

    public int PersonId { get; set; }

    public string SrlineBisnis { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? StartYear { get; set; }

    public string? EndYear { get; set; }

    public string? Company { get; set; }

    public string? Division { get; set; }

    public string? Location { get; set; }

    public string? JobDesc { get; set; }

    public string? SupervisorName { get; set; }

    public decimal? LastSalary { get; set; }

    public string? ReasonOfLeaving { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
