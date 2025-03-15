using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ManagementService
{
    public Guid ManagementServiceId { get; set; }

    public string InstanceName { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int Port { get; set; }

    public Guid? DefaultCollectionServiceId { get; set; }

    public virtual ICollection<CollectionService> CollectionServices { get; set; } = new List<CollectionService>();
}
