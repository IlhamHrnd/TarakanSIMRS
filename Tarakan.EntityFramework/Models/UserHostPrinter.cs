using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserHostPrinter
{
    public string UserHostName { get; set; }

    public string PrinterId { get; set; }

    public string Description { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
