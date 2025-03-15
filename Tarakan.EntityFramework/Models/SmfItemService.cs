using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SmfItemService
{
    public string SmfId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public bool? IsVisible { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
