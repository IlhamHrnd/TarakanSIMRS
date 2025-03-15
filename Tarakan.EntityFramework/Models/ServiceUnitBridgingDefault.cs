using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitBridgingDefault
{
    public string ServiceUnitId { get; set; } = null!;

    public string SrbridgingType { get; set; } = null!;

    public string BridgingPoliId { get; set; } = null!;

    public string? BridgingName { get; set; }

    public bool? IsActive { get; set; }

    public string BridgingSubSpesialisId { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public string? BridgingSubSpesialisName { get; set; }
}
