using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoringInfu
{
    public string RegistrationNo { get; set; }

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public string Srivcatheter { get; set; }

    public string SrinfusSet { get; set; }

    public bool? IsSetBlood { get; set; }

    public string SrinfusLocation { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsRedness { get; set; }

    public bool? IsFeelingHot { get; set; }

    public bool? IsSwollen { get; set; }

    public bool? IsPus { get; set; }

    public bool? IsKanulaCulture { get; set; }

    public string MedicineAndLiquid { get; set; }

    public string MedicationMethod { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string InfusLocation { get; set; }

    public DateTime? ReleaseDateTime { get; set; }

    public string Notes { get; set; }

    public string LiquidType { get; set; }

    public bool? IsDirty { get; set; }

    public string MonitoringByUserId { get; set; }

    public bool? IsApneu { get; set; }

    public bool? IsVeinHarden { get; set; }
}
