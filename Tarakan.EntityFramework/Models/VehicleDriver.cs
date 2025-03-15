using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VehicleDriver
{
    public int DriverId { get; set; }

    public string DriverName { get; set; } = null!;

    public string SrdriverStatus { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
