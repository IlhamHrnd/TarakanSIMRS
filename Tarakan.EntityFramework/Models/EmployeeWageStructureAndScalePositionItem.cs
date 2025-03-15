using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeWageStructureAndScalePositionItem
{
    public int WageStructureAndScalePositionItemId { get; set; }

    public int WageStructureAndScalePositionId { get; set; }

    public string SrwageStructureAndScaleType { get; set; } = null!;

    public int WageStructureAndScaleId { get; set; }

    public int WageStructureAndScaleItemId { get; set; }

    public decimal LoadPoint { get; set; }

    public decimal BasePoint { get; set; }

    public decimal Points { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
