using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuItem
{
    public string MenuItemId { get; set; } = null!;

    public string MenuItemName { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public string VersionId { get; set; } = null!;

    public string SeqNo { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
