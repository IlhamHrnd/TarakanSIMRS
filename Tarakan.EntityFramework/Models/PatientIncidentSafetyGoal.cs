using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentSafetyGoal
{
    public string PatientIncidentNo { get; set; }

    public string SrsafetyGoals { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
