using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessmentDiagnosa
{
    public string QuestionId { get; set; }

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

    public bool? IsUsingRange { get; set; }

    public decimal? AcceptedNum2 { get; set; }

    public int AgeInMonthStart { get; set; }

    public int AgeInMonthEnd { get; set; }

    public string SrnsDiagnosaPrefix { get; set; }

    public string SrnsDiagnosaSuffix { get; set; }

    public bool? ShowAssessmetAsPrefix { get; set; }

    public bool? ShowAssessmetAsSuffix { get; set; }

    public int Id { get; set; }

    public string SrnsMandatoryLevel { get; set; }

    public string Sex { get; set; }

    public virtual NursingDiagnosa NursingDiagnosa { get; set; }
}
