using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string PlateNo { get; set; }

    public string SrvehicleType { get; set; }

    public string SrvehicleStatus { get; set; }

    public string Notes { get; set; }

    public string AssetId { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
