using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeSoape
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime Soapedate { get; set; }

    public string Soapetime { get; set; } = null!;

    public string Subjective { get; set; } = null!;

    public string Objective { get; set; } = null!;

    public string Assesment { get; set; } = null!;

    public string Planning { get; set; } = null!;

    public string Evaluation { get; set; } = null!;

    public string AttendingNotes { get; set; } = null!;

    public bool IsSummary { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public bool? IsInformConcern { get; set; }

    public byte[]? BodyImage { get; set; }

    public bool? Imported { get; set; }

    public DateTime? ImportedDateTime { get; set; }

    public string? ToRegistrationInfoMedicId { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
