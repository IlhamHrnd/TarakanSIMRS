using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserSessionSetting
{
    public string UserId { get; set; }

    public string Key { get; set; }

    public string Value { get; set; }
}
