using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmergencyDiagnose
{
    public string EmrDiagnoseId { get; set; }

    public string EmrDiagnoseName { get; set; }

    public string SremrDiagnoseGroupId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
