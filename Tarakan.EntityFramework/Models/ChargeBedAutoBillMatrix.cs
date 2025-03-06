using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ChargeBedAutoBillMatrix
{
    public string SequenceNo { get; set; }

    public decimal MinHour { get; set; }

    public decimal MaxHour { get; set; }

    public decimal PercentageAmount { get; set; }

    public decimal ValueAmount { get; set; }
}
