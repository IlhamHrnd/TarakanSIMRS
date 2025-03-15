using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Diagnose
{
    public string DiagnoseId { get; set; } = null!;

    public string? DtdNo { get; set; }

    public string DiagnoseName { get; set; } = null!;

    public bool IsChronicDisease { get; set; }

    public bool IsDisease { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Synonym { get; set; }

    public virtual Dtd? DtdNoNavigation { get; set; }
}
