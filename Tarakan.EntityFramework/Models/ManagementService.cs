using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ManagementService
{
    public Guid ManagementServiceId { get; set; }

    public string InstanceName { get; set; }

    public string MachineName { get; set; }

    public string Address { get; set; }

    public int Port { get; set; }

    public Guid? DefaultCollectionServiceId { get; set; }

    public virtual ICollection<CollectionService> CollectionServices { get; set; } = new List<CollectionService>();
}
