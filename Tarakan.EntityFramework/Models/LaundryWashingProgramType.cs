using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryWashingProgramType
{
    public int LaundryProgramTypeId { get; set; }

    public string SrlaundryProcessType { get; set; } = null!;

    public string SrlaundryProgram { get; set; } = null!;

    public string SrlaundryType { get; set; } = null!;

    public decimal? Weight { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
