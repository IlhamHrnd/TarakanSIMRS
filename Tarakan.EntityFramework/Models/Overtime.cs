using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Overtime
{
    public int OvertimeId { get; set; }

    public string OvertimeName { get; set; } = null!;

    public int SalaryComponentId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
