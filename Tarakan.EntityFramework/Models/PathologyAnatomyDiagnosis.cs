using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyDiagnosis
{
    public string ResultType { get; set; } = null!;

    public string DiagnosisId { get; set; } = null!;

    public string? DiagnosisName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
