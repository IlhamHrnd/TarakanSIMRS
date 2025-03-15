using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemServiceSubSpecialty
{
    public string ItemId { get; set; } = null!;

    public string SubSpecialtyId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
