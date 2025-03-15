using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessment
{
    public string NursingAssessmentId { get; set; } = null!;

    public string NursingAssessmentName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsSubjective { get; set; }

    public bool IsObjective { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string? QuestionId { get; set; }
}
