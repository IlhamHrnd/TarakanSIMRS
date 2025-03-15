using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserSessionSetting
{
    public string UserId { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}
