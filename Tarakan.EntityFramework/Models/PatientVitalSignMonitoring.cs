using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientVitalSignMonitoring
{
    public string RegistrationNo { get; set; }

    public string OrderNo { get; set; }

    public DateTime StartingDate { get; set; }

    public string StartingTime { get; set; }

    public DateTime EndingDate { get; set; }

    public string EndingTime { get; set; }

    public string Interval { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual ICollection<PatientVitalSignMonitoringItem> PatientVitalSignMonitoringItems { get; set; } = new List<PatientVitalSignMonitoringItem>();
}
