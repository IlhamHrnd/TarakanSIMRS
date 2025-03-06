using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyDiagnosis
{
    public string ResultType { get; set; }

    public string DiagnosisId { get; set; }

    public string DiagnosisName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
