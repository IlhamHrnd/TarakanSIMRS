using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessmentDiagnosaRen
{
    public string NursingAssessmentId { get; set; }

    public string NursingDiagnosaId { get; set; }

    public string SranswerType { get; set; }

    public string Operand { get; set; }

    public string AcceptedText { get; set; }

    public decimal? AcceptedNum { get; set; }

    public bool CheckValue { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public virtual NursingAssessment NursingAssessment { get; set; }
}
