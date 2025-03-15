using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BedBpj
{
    public int? ClassId { get; set; }

    public string? ClassName { get; set; }

    public int? BedAvailableM { get; set; }

    public int? BedAvailableF { get; set; }

    public int? BedOccupiedM { get; set; }

    public int? BedOccupiedF { get; set; }

    public string? Notes { get; set; }
}
