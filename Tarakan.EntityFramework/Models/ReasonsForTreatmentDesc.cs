using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReasonsForTreatmentDesc
{
    public string SrreasonVisit { get; set; }

    public string ReasonsForTreatmentId { get; set; }

    public string ReasonsForTreatmentDescId { get; set; }

    public string ReasonsForTreatmentDescName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
