using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageStructureAndScaleItem
{
    public int WageStructureAndScaleItemId { get; set; }

    public int WageStructureAndScaleId { get; set; }

    public string SrwageStructureAndScaleItem { get; set; } = null!;

    public decimal Points { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
