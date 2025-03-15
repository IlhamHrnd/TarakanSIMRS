using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageStructureAndScale
{
    public int WageStructureAndScaleId { get; set; }

    public string SrwageStructureAndScaleType { get; set; } = null!;

    public string WageStructureAndScaleCode { get; set; } = null!;

    public string WageStructureAndScaleName { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
