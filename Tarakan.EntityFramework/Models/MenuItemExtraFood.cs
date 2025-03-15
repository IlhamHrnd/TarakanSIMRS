using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItemExtraFood
{
    public string SeqNo { get; set; } = null!;

    public string SrdayName { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public string? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
