using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Obatdiskon
{
    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public double? Discount1Percentage { get; set; }

    public double? Discount2Percentage { get; set; }

    public double? Price { get; set; }
}
