using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwPelangganBku
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public int Type { get; set; }
}
