using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlueRoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual BpjsRujukanCodeBlueRole Role { get; set; }
}
