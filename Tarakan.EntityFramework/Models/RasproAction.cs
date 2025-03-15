using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RasproAction
{
    public string RasproLineId { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public int ActionNo { get; set; }

    public string ActionDescription { get; set; } = null!;

    public int AntibioticLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
