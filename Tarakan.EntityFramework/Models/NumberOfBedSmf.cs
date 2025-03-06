using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NumberOfBedSmf
{
    public DateTime StartingDate { get; set; }

    public string ClassId { get; set; }

    public string SmfId { get; set; }

    public int NumberOfBed { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
