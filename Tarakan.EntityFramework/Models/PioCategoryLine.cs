using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PioCategoryLine
{
    public int PioNo { get; set; }

    public string SrpioCategory { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
