using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientImmunizationOther
{
    public string PatientId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Imunization { get; set; }
}
