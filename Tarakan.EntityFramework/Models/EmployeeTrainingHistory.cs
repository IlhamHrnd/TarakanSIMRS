using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingHistory
{
    public int EmployeeTrainingHistoryId { get; set; }

    public int PersonId { get; set; }

    public string? EventName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? TrainingLocation { get; set; }

    public string? TrainingInstitution { get; set; }

    public decimal? Fee { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsAttending { get; set; }

    public int? EmployeeTrainingId { get; set; }

    public decimal? SponsorFee { get; set; }

    public int? TotalHour { get; set; }

    public bool? IsInHouseTraining { get; set; }

    public decimal? CreditPoint { get; set; }

    public bool? IsScheduledTraining { get; set; }

    public string? SractivityType { get; set; }

    public DateTime? CertificateValidityPeriod { get; set; }

    public bool? IsCommitmentToWork { get; set; }

    public short? LengthOfService { get; set; }

    public DateTime? StartServiceDate { get; set; }

    public DateTime? EndServiceDate { get; set; }

    public string? SrtrainingFinancingSources { get; set; }

    public DateTime? EvaluationDate { get; set; }

    public string? EvaluationNote { get; set; }

    public DateTime? EvaluationNoteDateTime { get; set; }

    public string? SupervisorEvaluationNote { get; set; }

    public DateTime? SupervisorEvaluationDateTime { get; set; }

    public string? SupervisorEvaluationNoteByUserId { get; set; }

    public decimal? DurationHour { get; set; }

    public decimal? DurationMinutes { get; set; }

    public string? SremployeeTrainingPointType { get; set; }

    public string? SremployeeTrainingDateSeparator { get; set; }

    public string? SremployeeTrainingRole { get; set; }

    public string? SractivitySubType { get; set; }

    public decimal? PlanningCosts { get; set; }

    public decimal? EvaluationScore { get; set; }

    public string? Recommendation { get; set; }
}
