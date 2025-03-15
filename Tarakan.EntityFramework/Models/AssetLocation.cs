using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetLocation
{
    public string AssetLocationId { get; set; } = null!;

    public string AssetLocationName { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string Approver { get; set; } = null!;

    public string PersonInCharge { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
