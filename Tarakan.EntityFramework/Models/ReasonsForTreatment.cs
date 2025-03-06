using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReasonsForTreatment
{
    public string SrreasonVisit { get; set; }

    public string ReasonsForTreatmentId { get; set; }

    public string ReasonsForTreatmentName { get; set; }

    public string DiagnoseId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
