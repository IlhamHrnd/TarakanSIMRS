using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentUnderlyingCausesItemComponent
{
    public string PatientIncidentNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string FactorId { get; set; }

    public string FactorItemId { get; set; }

    public string ComponentId { get; set; }

    public string ComponentName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
