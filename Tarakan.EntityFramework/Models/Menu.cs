using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Menu
{
    public string MenuId { get; set; } = null!;

    public string MenuName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
