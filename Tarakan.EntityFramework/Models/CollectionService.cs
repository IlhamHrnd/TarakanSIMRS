using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CollectionService
{
    public Guid CollectionServiceId { get; set; }

    public string InstanceName { get; set; }

    public string MachineName { get; set; }

    public string Address { get; set; }

    public int Port { get; set; }

    public bool Enabled { get; set; }

    public DateTime? LastHeartbeatUtc { get; set; }

    public Guid ManagementServiceId { get; set; }

    public virtual ManagementService ManagementService { get; set; }
}
