using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PositionResponsibility
{
    public int PositionResponsibilityId { get; set; }

    public int PositionId { get; set; }

    public string ResponsibilityName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
