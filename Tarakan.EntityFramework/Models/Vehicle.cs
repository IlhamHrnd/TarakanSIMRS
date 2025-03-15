using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string PlateNo { get; set; } = null!;

    public string SrvehicleType { get; set; } = null!;

    public string SrvehicleStatus { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string? AssetId { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
