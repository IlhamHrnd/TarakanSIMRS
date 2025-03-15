using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeEducation
{
    public int EmployeeEducationId { get; set; }

    public int PersonId { get; set; }

    public string? SreducationStatus { get; set; }

    public string? SreducationFinancingSources { get; set; }

    public bool? IsTuitionAssistance { get; set; }

    public decimal? AssistanceAmount { get; set; }

    public string? InstitutionName { get; set; }

    public string? StudyProgram { get; set; }

    public string? StartYearPeriod { get; set; }

    public string? EndYearPeriod { get; set; }

    public string? SrstudyPeriodStatus { get; set; }

    public bool? IsCommitmentToWork { get; set; }

    public string? DurationOfService { get; set; }

    public DateTime? StartServiceDate { get; set; }

    public DateTime? EndServiceDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
