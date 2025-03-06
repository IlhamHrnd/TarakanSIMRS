﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrintJobParameterLog
{
    public long PrintNo { get; set; }

    public string Name { get; set; }

    public string ValueString { get; set; }

    public decimal? ValueNumeric { get; set; }

    public DateTime? ValueDateTime { get; set; }
}
