using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MirroringPreferredConfig
{
    public Guid MirroringGuid { get; set; }

    public int? MirrorInstanceId { get; set; }

    public int? PrincipalInstanceId { get; set; }

    public bool NormalConfiguration { get; set; }

    public string DatabaseName { get; set; }

    public string WitnessAddress { get; set; }
}
