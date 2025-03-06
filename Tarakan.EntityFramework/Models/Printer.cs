﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Printer
{
    public string PrinterId { get; set; }

    public string PrinterName { get; set; }

    public string PrinterLocationHost { get; set; }

    public string PrinterManagerHost { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
