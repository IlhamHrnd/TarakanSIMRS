using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IncidentTypeItem
{
    public string SrincidentType { get; set; } = null!;

    public string ComponentId { get; set; } = null!;

    public string SubComponentId { get; set; } = null!;

    public string SubComponentName { get; set; } = null!;

    public bool IsAllowEdit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
