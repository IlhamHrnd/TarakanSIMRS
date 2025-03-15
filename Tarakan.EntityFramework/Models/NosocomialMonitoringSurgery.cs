using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoringSurgery
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SrexudateCharacter { get; set; }

    public bool? IsAfDrain { get; set; }

    public bool? IsAfSuture { get; set; }

    public bool? IsRedness { get; set; }

    public bool? IsSwollen { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsFeelingHot { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPus { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsCulture { get; set; }

    public string? InjuryCondition { get; set; }

    public string? MonitoringByUserId { get; set; }

    public bool? IsIdoDiagnose { get; set; }
}
