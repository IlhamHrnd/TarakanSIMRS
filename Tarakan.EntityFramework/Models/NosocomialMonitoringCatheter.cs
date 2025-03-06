using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoringCatheter
{
    public string RegistrationNo { get; set; }

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string SrgeneralChateterNo { get; set; }

    public string SrsiliconChateterNo { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsDisuria { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsPyuria { get; set; }

    public bool? IsHematuria { get; set; }

    public bool? IsUrineCulture { get; set; }

    public string Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsUrineBagChange { get; set; }

    public string FixationFluid { get; set; }

    public string MonitoringByUserId { get; set; }

    public bool? IsRelease { get; set; }

    public bool? IsApneu { get; set; }

    public bool? IsIskDiagnose { get; set; }
}
