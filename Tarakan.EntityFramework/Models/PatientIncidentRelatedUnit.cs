using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientIncidentRelatedUnit
{
    public string PatientIncidentNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string IncidentDirectCause { get; set; }

    public string IncidentUnderlyingCauses { get; set; }

    public string InvestigationByUserId { get; set; }

    public DateTime? InvestigationDateTime { get; set; }

    public bool? IsInvestigationApproved { get; set; }

    public string InvestigationApprovedByUserId { get; set; }

    public DateTime? InvestigationApprovedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string IncidentChronologyCauses { get; set; }
}
