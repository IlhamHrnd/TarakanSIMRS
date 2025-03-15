using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IncidentType
{
    public string SrincidentType { get; set; } = null!;

    public string ComponentId { get; set; } = null!;

    public string ComponentName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
