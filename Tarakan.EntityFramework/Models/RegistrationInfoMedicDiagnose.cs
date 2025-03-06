using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoMedicDiagnose
{
    public string RegistrationInfoMedicId { get; set; }

    public string SequenceNo { get; set; }

    public string DiagnoseId { get; set; }

    public string DiagnosisText { get; set; }

    public string SrdiagnoseType { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime DiagnoseDateTime { get; set; }

    public string ParamedicId { get; set; }

    public bool IsOldCase { get; set; }

    public bool IsVoid { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string ExternalCauseId { get; set; }
}
