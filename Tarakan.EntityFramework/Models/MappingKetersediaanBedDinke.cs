using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MappingKetersediaanBedDinke
{
    public string Category { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string? JenisKamar { get; set; }

    public string? Kelas { get; set; }
}
