using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InosinfectionMonitoring
{
    public long MonitoringId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string BedId { get; set; } = null!;

    public DateTime MonitoringDate { get; set; }

    public bool? IsMechanicalVentilator { get; set; }

    public bool? IsInpatient { get; set; }

    public bool? IsUrineCatheter { get; set; }

    public bool? IsSurgery { get; set; }

    public bool? IsCentralVeinLine { get; set; }

    public bool? IsIntraVeinLine { get; set; }

    public bool? IsTotalCare { get; set; }

    public bool? IsAntibioticDrugs { get; set; }

    public bool? IsVap { get; set; }

    public bool? IsHap { get; set; }

    public bool? IsIsk { get; set; }

    public bool? IsIlo { get; set; }

    public bool? IsIadp { get; set; }

    public bool? IsPhlebitis { get; set; }

    public bool? IsDecubitus { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
