using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeDiagnoseInaGroupper
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string DiagnoseId { get; set; } = null!;

    public string SrdiagnoseType { get; set; } = null!;

    public string DiagnosisText { get; set; } = null!;

    public string? MorphologyId { get; set; }

    public string ParamedicId { get; set; } = null!;

    public bool IsAcuteDisease { get; set; }

    public bool IsChronicDisease { get; set; }

    public bool IsOldCase { get; set; }

    public bool IsConfirmed { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ExternalCauseId { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
