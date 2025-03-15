using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlueRole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<BpjsRujukanCodeBlueRoleClaim> BpjsRujukanCodeBlueRoleClaims { get; set; } = new List<BpjsRujukanCodeBlueRoleClaim>();

    public virtual ICollection<BpjsRujukanCodeBlueUser1> Users { get; set; } = new List<BpjsRujukanCodeBlueUser1>();
}
