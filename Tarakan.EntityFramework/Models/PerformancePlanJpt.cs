using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanJpt
{
    public int PerformancePlanId { get; set; }

    public int OrganizationUnitId { get; set; }

    public int SubOrganizationUnitId { get; set; }

    public int PositionId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
