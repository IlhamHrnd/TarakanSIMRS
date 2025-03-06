using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppControlEntryMatrix
{
    public string HealthcareInitialAppsVersion { get; set; }

    public string EntryType { get; set; }

    public string ControlId { get; set; }

    public int IndexNo { get; set; }

    public bool IsVisible { get; set; }

    public string ReferenceValue { get; set; }

    public bool? IsPanelCollapse { get; set; }
}
