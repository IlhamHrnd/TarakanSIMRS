using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CensusBalance
{
    public DateTime CensusDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string SmfId { get; set; }

    public int? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? NumberOfBed { get; set; }
}
