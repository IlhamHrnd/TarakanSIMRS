using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Immunization
{
    public string ImmunizationId { get; set; } = null!;

    public string ImmunizationName { get; set; } = null!;

    public int MaxCount { get; set; }

    public int? IndexNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
