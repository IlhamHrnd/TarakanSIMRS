using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VirtualHostServer
{
    public int VhostId { get; set; }

    public string VhostName { get; set; } = null!;

    public string VhostAddress { get; set; } = null!;

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime RegisteredDate { get; set; }

    public string ServerType { get; set; } = null!;
}
