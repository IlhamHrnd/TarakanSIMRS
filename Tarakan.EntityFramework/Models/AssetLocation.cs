using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetLocation
{
    public string AssetLocationId { get; set; }

    public string AssetLocationName { get; set; }

    public string DepartmentId { get; set; }

    public string ServiceUnitId { get; set; }

    public string Approver { get; set; }

    public string PersonInCharge { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
