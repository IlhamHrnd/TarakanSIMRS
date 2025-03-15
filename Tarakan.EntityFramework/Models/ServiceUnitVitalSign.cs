using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitVitalSign
{
    public string ServiceUnitId { get; set; } = null!;

    public string VitalSignId { get; set; } = null!;

    public int? RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
