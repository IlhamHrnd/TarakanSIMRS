using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryWashingProgramType
{
    public int LaundryProgramTypeId { get; set; }

    public string SrlaundryProcessType { get; set; }

    public string SrlaundryProgram { get; set; }

    public string SrlaundryType { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
