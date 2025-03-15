using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MasterMapping
{
    public string ItemIdMapping { get; set; } = null!;

    public string NamaTindakan { get; set; } = null!;

    public decimal? Tarif { get; set; }

    public string? JenisTindakan { get; set; }

    public string? GroupTindakan { get; set; }

    public string? ItemId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Userid { get; set; }

    public decimal? Price { get; set; }
}
