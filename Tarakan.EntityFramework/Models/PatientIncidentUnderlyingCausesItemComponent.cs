using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentUnderlyingCausesItemComponent
{
    public string PatientIncidentNo { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string FactorId { get; set; } = null!;

    public string FactorItemId { get; set; } = null!;

    public string ComponentId { get; set; } = null!;

    public string? ComponentName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
