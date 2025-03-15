using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientResearch
{
    public int ResearchId { get; set; }

    public string PatientId { get; set; } = null!;

    public string ResearchTitle { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
