using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppControlEntryMatrix
{
    public string HealthcareInitialAppsVersion { get; set; } = null!;

    public string EntryType { get; set; } = null!;

    public string ControlId { get; set; } = null!;

    public int IndexNo { get; set; }

    public bool IsVisible { get; set; }

    public string? ReferenceValue { get; set; }

    public bool? IsPanelCollapse { get; set; }
}
