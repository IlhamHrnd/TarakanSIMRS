using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NumberOfBed
{
    public DateTime StartingDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public int NumberOfBed1 { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
