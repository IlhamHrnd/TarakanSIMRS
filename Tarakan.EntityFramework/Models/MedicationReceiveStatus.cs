using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReceiveStatus
{
    public long MedicationReceiveNo { get; set; }

    public DateTime StatusDateTime { get; set; }

    public bool? IsMedicationStop { get; set; }

    public string? SrmedicationStopReason { get; set; }

    public string? MedicationReason { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SrmedicationStatusReason { get; set; }

    public string? SrmedicationStatusType { get; set; }
}
