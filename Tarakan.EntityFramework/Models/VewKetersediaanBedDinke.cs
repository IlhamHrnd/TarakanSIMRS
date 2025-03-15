using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VewKetersediaanBedDinke
{
    public int? Kapasitas { get; set; }

    public int? Ketersediaan { get; set; }

    public string Category { get; set; } = null!;

    public string? JenisKamar { get; set; }

    public string ClassId { get; set; } = null!;
}
