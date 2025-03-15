using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlwaysOnAvailabilityGroup
{
    public long GroupTopologyId { get; set; }

    public Guid GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string ServerSourceName { get; set; } = null!;

    public string ListenerDnsName { get; set; } = null!;

    public int ListenerPort { get; set; }

    public string? ListenerIpAddress { get; set; }

    public bool Active { get; set; }

    public bool Delete { get; set; }
}
