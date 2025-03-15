using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoringHap
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string? SrettType { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsLeukopenia { get; set; }

    public bool? IsLeukositosis { get; set; }

    public bool? IsSputum { get; set; }

    public bool? IsCough { get; set; }

    public bool? IsDipsnoe { get; set; }

    public bool? IsWetRonchi { get; set; }

    public bool? IsDesaturasi { get; set; }

    public bool? IsCulture { get; set; }

    public bool? IsRadiology { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsElbowConnectorRepl { get; set; }

    public bool? IsHumidificationRepl { get; set; }

    public bool? IsGuedeleRepl { get; set; }

    public bool? IsTidalVolChange { get; set; }

    public bool? IsRrChange { get; set; }

    public bool? IsModeVentChange { get; set; }

    public string? SputumColor { get; set; }

    public string? Leukosit { get; set; }

    public string? Thorax { get; set; }

    public string? MonitoringByUserId { get; set; }

    public bool? IsRelease { get; set; }

    public bool? IsBradikardi { get; set; }

    public bool? IsDispenea { get; set; }

    public bool? IsSpO2lessThan94 { get; set; }

    public bool? IsVapDiagnose { get; set; }
}
