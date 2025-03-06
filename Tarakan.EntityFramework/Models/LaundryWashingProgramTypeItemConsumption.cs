﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryWashingProgramTypeItemConsumption
{
    public string SrlaundryProcessType { get; set; }

    public string SrlaundryProgram { get; set; }

    public string SrlaundryType { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
