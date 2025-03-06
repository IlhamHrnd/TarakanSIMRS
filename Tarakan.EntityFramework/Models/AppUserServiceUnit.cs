﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserServiceUnit
{
    public string UserId { get; set; }

    public string ServiceUnitId { get; set; }

    public bool? IsDiscontinue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
