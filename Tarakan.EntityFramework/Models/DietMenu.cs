using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietMenu
{
    public string DietId { get; set; } = null!;

    public string FormOfFood { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
