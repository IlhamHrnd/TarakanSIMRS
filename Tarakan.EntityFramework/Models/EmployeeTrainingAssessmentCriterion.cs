using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingAssessmentCriterion
{
    public int AssessmentCriteriaId { get; set; }

    public string AssessmentCriteriaName { get; set; } = null!;

    public string Recommendation { get; set; } = null!;

    public decimal MinValue { get; set; }

    public decimal MaxValue { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
