using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentInvestigation
{
    public string PatientIncidentNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string SeqNo { get; set; }

    public string Recomendation { get; set; }

    public DateTime? RecomendationDateTime { get; set; }

    public string PersonInCharge { get; set; }

    public string Implementation { get; set; }

    public DateTime? ImplementationDateTime { get; set; }

    public string FollowUp { get; set; }

    public DateTime? FollowUpDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
