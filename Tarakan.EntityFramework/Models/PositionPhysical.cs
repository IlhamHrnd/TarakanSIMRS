using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionPhysical
{
    public int PositionPhysicalId { get; set; }

    public int PositionId { get; set; }

    public string? SrphysicalCharacteristic { get; set; }

    public string? SroperandType { get; set; }

    public string? PhysicalValue { get; set; }

    public string? SrmeasurementCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
