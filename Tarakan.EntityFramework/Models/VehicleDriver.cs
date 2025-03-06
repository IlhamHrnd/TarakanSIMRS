using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VehicleDriver
{
    public int DriverId { get; set; }

    public string DriverName { get; set; }

    public string SrdriverStatus { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
