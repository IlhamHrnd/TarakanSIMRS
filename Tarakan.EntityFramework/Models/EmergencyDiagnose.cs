using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmergencyDiagnose
{
    public string EmrDiagnoseId { get; set; } = null!;

    public string EmrDiagnoseName { get; set; } = null!;

    public string? SremrDiagnoseGroupId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
