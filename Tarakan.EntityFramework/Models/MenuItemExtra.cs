using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItemExtra
{
    public string SeqNo { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public DateTime StartingDate { get; set; }

    public string SrmealSet { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
