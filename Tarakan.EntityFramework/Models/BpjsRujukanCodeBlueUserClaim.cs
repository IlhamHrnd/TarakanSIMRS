using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlueUserClaim
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual BpjsRujukanCodeBlueUser User { get; set; }
}
