using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AbRestriction
{
    public string AbRestrictionId { get; set; } = null!;

    public string? ParentId { get; set; }

    public string AbRestrictionName { get; set; } = null!;

    public string SrabRestrictionType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsNotRestricted { get; set; }
}
