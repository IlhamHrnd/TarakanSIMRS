using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetMovement
{
    public string AssetMovementNo { get; set; }

    public DateTime MovementDate { get; set; }

    public string AssetId { get; set; }

    public string FromDepartmentId { get; set; }

    public string FromServiceUnitId { get; set; }

    public string FromAssetLocationId { get; set; }

    public string ToDepartmentId { get; set; }

    public string ToServiceUnitId { get; set; }

    public string ToAssetLocationId { get; set; }

    public string Notes { get; set; }

    public bool IsPosted { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }
}
