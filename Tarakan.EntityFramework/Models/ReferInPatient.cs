using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReferInPatient
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public DateTime? ReferDateTime { get; set; }

    public string FromParamedicId { get; set; } = null!;

    public string ToParamedicId { get; set; } = null!;

    public string ActionExamTreatment { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Answer { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
