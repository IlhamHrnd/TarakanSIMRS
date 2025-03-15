using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WebFramework
{
    public int WebFrameworkId { get; set; }

    public string? HostName { get; set; }

    public string? Port { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? InstanceName { get; set; }

    public int? ProductId { get; set; }
}
