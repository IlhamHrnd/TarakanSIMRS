using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalDischargeSummaryDiagnose
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DiagnoseId { get; set; } = null!;

    public string SrdiagnoseType { get; set; } = null!;

    public string DiagnosisText { get; set; } = null!;

    public string? ExternalCauseId { get; set; }

    public bool IsOldCase { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }
}
