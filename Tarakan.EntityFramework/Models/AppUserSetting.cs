using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserSetting
{
    public string UserId { get; set; } = null!;

    public string? QueueingCounterSetting { get; set; }
}
