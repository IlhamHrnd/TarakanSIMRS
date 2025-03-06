using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalParticipantItem
{
    public int ParticipantItemId { get; set; }

    public int ParticipantId { get; set; }

    public int EmployeeId { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? ClosedDateTime { get; set; }

    public string ClosedByUserId { get; set; }

    public int? PositionId { get; set; }

    public DateTime? PositionValidFromDate { get; set; }

    public int? OrganizationUnitId { get; set; }

    public int? SubOrganizationUnitId { get; set; }

    public string ServiceUnitId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? SubDivisonId { get; set; }
}
