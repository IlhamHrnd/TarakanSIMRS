﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwItemProductSalesAvailable
{
    public string ItemId { get; set; } = null!;

    public bool? IsSalesAvailable { get; set; }
}
