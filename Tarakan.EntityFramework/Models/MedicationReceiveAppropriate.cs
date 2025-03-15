using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReceiveAppropriate
{
    public long MedicationReceiveNo { get; set; }

    public string AppropriateType { get; set; } = null!;

    public string? SrmedicationNotAppropriateReason { get; set; }

    public string? MedicationReason { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CratedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
