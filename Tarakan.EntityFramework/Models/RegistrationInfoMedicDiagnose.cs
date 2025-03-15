using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoMedicDiagnose
{
    public string RegistrationInfoMedicId { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DiagnoseId { get; set; } = null!;

    public string DiagnosisText { get; set; } = null!;

    public string SrdiagnoseType { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime DiagnoseDateTime { get; set; }

    public string ParamedicId { get; set; } = null!;

    public bool IsOldCase { get; set; }

    public bool IsVoid { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ExternalCauseId { get; set; }
}
