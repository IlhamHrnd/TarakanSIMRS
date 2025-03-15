using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VisitType
{
    public string VisitTypeId { get; set; } = null!;

    public string VisitTypeName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
