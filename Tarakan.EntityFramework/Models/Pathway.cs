using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Pathway
{
    public string PathwayId { get; set; }

    public string PathwayName { get; set; }

    public DateTime StartingDate { get; set; }

    public decimal CoverageValue1 { get; set; }

    public decimal CoverageValue2 { get; set; }

    public decimal CoverageValue3 { get; set; }

    public int Alos { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
