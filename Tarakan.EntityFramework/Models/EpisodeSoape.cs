using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeSoape
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public string ParamedicId { get; set; }

    public DateTime Soapedate { get; set; }

    public string Soapetime { get; set; }

    public string Subjective { get; set; }

    public string Objective { get; set; }

    public string Assesment { get; set; }

    public string Planning { get; set; }

    public string Evaluation { get; set; }

    public string AttendingNotes { get; set; }

    public bool IsSummary { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ServiceUnitId { get; set; }

    public bool? IsInformConcern { get; set; }

    public byte[] BodyImage { get; set; }

    public bool? Imported { get; set; }

    public DateTime? ImportedDateTime { get; set; }

    public string ToRegistrationInfoMedicId { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
