using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReceiveFromPatient
{
    public long MedicationReceiveNo { get; set; }

    public DateTime? LastConsumeDateTime { get; set; }

    public string? Condition { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? ApprovedByParamedicId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? Reason { get; set; }

    public string? Duration { get; set; }

    public string? Temp { get; set; }

    public DateTime? BeyondUseDate { get; set; }

    public string? RegPom { get; set; }

    public bool? IsAppropriate { get; set; }

    public bool? IsManagedByPatient { get; set; }
}
