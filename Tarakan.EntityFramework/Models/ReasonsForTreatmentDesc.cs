using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReasonsForTreatmentDesc
{
    public string SrreasonVisit { get; set; } = null!;

    public string ReasonsForTreatmentId { get; set; } = null!;

    public string ReasonsForTreatmentDescId { get; set; } = null!;

    public string ReasonsForTreatmentDescName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
