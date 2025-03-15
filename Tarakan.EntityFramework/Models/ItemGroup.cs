using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemGroup
{
    public string ItemGroupId { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public string? SritemType { get; set; }

    public decimal CitoValue { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public string? AccountId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Initial { get; set; }

    public string? RestrictionUserType { get; set; }

    public string? CssClass { get; set; }
}
