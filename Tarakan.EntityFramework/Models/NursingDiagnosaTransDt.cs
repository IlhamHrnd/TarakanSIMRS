using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosaTransDt
{
    public long Id { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string NursingDiagnosaId { get; set; } = null!;

    public string? NursingDiagnosaName { get; set; }

    public string SrnursingDiagnosaLevel { get; set; } = null!;

    public string? NursingDiagnosaParentId { get; set; }

    public int Priority { get; set; }

    public int Skala { get; set; }

    public int Target { get; set; }

    public string? Respond { get; set; }

    public int Evaluasi { get; set; }

    public bool Reexamine { get; set; }

    public DateTime ExecuteDateTime { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string TmpNursingDiagnosaId { get; set; } = null!;

    public string TmpNursingDiagnosaParentId { get; set; } = null!;

    public int? EvalPeriod { get; set; }

    public int? PeriodConversionInHour { get; set; }

    public string? S { get; set; }

    public string? O { get; set; }

    public string? A { get; set; }

    public string? SrnursingCarePlanning { get; set; }

    public string? P { get; set; }

    public long? ParentId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ReferenceToPhrNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsPrmrj { get; set; }

    public string? PpaInstruction { get; set; }

    public string? SruserType { get; set; }

    public string? PrescriptionCurrentDay { get; set; }

    public string? SubmitBy { get; set; }

    public string? ReceiveBy { get; set; }

    public string? SrnsType { get; set; }

    public int? TemplateId { get; set; }

    public string? Info5 { get; set; }

    public string? DpjpNotes { get; set; }

    public string? ParamedicId { get; set; }
}
