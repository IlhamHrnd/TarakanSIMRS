using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitBridgingDefault
{
    public string ServiceUnitId { get; set; }

    public string SrbridgingType { get; set; }

    public string BridgingPoliId { get; set; }

    public string BridgingName { get; set; }

    public bool? IsActive { get; set; }

    public string BridgingSubSpesialisId { get; set; }

    public bool? IsDefault { get; set; }

    public string BridgingSubSpesialisName { get; set; }
}
