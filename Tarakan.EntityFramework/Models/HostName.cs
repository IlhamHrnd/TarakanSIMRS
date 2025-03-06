using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HostName
{
    public int HostNameId { get; set; }

    public string HostName1 { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();
}
