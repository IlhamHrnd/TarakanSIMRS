using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlueUserLogin
{
    public string LoginProvider { get; set; }

    public string ProviderKey { get; set; }

    public string ProviderDisplayName { get; set; }

    public string UserId { get; set; }

    public virtual BpjsRujukanCodeBlueUser User { get; set; }
}
