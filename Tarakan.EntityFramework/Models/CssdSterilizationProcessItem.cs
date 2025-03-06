﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterilizationProcessItem
{
    public string ProcessNo { get; set; }

    public string ProcessSeqNo { get; set; }

    public string ReceivedNo { get; set; }

    public string ReceivedSeqNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
