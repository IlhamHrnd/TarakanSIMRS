using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InfectionAntibiotic
{
    public string InfectionId { get; set; } = null!;

    public int AntibioticLevel { get; set; }

    public string ItemId { get; set; } = null!;

    public bool IsAlternative { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
