using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Dtd
{
    public string DtdNo { get; set; } = null!;

    public string DtdName { get; set; } = null!;

    public string DtdLabel { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SrchronicDisease { get; set; }

    public virtual ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();
}
