using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientVitalSignMonitoringItem
{
    public string RegistrationNo { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public string VitalSignId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual PatientVitalSignMonitoring PatientVitalSignMonitoring { get; set; } = null!;
}
