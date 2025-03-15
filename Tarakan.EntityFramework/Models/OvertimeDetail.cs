using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class OvertimeDetail
{
    public int OvertimeDetailId { get; set; }

    public int OvertimeId { get; set; }

    public decimal HourFrom { get; set; }

    public decimal HourTo { get; set; }

    public decimal Value { get; set; }

    public decimal? Formula { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
