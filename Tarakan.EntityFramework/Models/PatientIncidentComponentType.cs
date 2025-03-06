using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentComponentType
{
    public string PatientIncidentNo { get; set; }

    public string SrincidentType { get; set; }

    public string ComponentId { get; set; }

    public string SubComponentId { get; set; }

    public string SubComponentName { get; set; }

    public string Modus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
