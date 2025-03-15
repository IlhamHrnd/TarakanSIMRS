using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlserverVersion
{
    public int MajorVersion { get; set; }

    public int MinorVersion { get; set; }

    public int BuildNumber { get; set; }

    public string? VersionName { get; set; }

    public string? ServicePackName { get; set; }
}
