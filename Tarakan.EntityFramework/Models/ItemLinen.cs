using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemLinen
{
    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
