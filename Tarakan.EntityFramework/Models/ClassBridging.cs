using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClassBridging
{
    public string ClassId { get; set; } = null!;

    public string SrbridgingType { get; set; } = null!;

    public string BridgingId { get; set; } = null!;

    public string BridgingName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
