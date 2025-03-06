using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientVitalSignMonitoringItem
{
    public string RegistrationNo { get; set; }

    public string OrderNo { get; set; }

    public string VitalSignId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual PatientVitalSignMonitoring PatientVitalSignMonitoring { get; set; }
}
