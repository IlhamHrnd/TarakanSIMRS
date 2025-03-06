using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClosingAccounting
{
    public string YearNo { get; set; }

    public string MonthNo { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
