using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeTrainingAssessmentAspect
{
    public string AssessmentAspectId { get; set; }

    public string AssessmentAspectName { get; set; }

    public decimal MinValue { get; set; }

    public decimal MaxValue { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
