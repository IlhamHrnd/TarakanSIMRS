using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessmentDiagnosaRen
{
    public string NursingAssessmentId { get; set; } = null!;

    public string NursingDiagnosaId { get; set; } = null!;

    public string? SranswerType { get; set; }

    public string? Operand { get; set; }

    public string? AcceptedText { get; set; }

    public decimal? AcceptedNum { get; set; }

    public bool CheckValue { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public virtual NursingAssessment NursingAssessment { get; set; } = null!;
}
