using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanNonJpt
{
    public int PerformancePlanId { get; set; }

    public string StartMonth { get; set; } = null!;

    public string EndMonth { get; set; } = null!;

    public int OrganizationUnitId { get; set; }

    public int SubOrganizationUnitId { get; set; }

    public int PositionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
