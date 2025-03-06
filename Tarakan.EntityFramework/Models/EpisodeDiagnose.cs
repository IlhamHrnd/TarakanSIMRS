using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeDiagnose
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public string DiagnoseId { get; set; }

    public string SrdiagnoseType { get; set; }

    public string DiagnosisText { get; set; }

    public string MorphologyId { get; set; }

    public string ParamedicId { get; set; }

    public bool IsAcuteDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    public bool IsOldCase { get; set; }

    public bool IsConfirmed { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ExternalCauseId { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
