using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMovement
{
    public string AssetMovementNo { get; set; } = null!;

    public DateTime MovementDate { get; set; }

    public string AssetId { get; set; } = null!;

    public string FromDepartmentId { get; set; } = null!;

    public string FromServiceUnitId { get; set; } = null!;

    public string FromAssetLocationId { get; set; } = null!;

    public string ToDepartmentId { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string ToAssetLocationId { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsPosted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }
}
