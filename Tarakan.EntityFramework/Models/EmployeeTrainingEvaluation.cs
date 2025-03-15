using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingEvaluation
{
    public int EmployeeTrainingHistoryId { get; set; }

    public string AssessmentAspectId { get; set; } = null!;

    public decimal RatingResult { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
