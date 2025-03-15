using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CensusBalance
{
    public DateTime CensusDate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string SmfId { get; set; } = null!;

    public int? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? NumberOfBed { get; set; }
}
