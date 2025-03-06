using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InvBalDes22
{
    public string LocationId { get; set; }

    public string LocationName { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public double? SaJml { get; set; }

    public double? SaNilai { get; set; }

    public double? InJml { get; set; }

    public double? InNilai { get; set; }

    public double? OutJml { get; set; }

    public double? OutNilai { get; set; }

    public double? BalJml { get; set; }

    public double? BalNilai { get; set; }

    public double? Hpr { get; set; }
}
