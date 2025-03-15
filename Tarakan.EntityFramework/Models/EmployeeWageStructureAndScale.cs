using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeWageStructureAndScale
{
    public int EmployeeWageStructureAndScaleId { get; set; }

    public int PersonId { get; set; }

    public DateTime ValidFrom { get; set; }

    public int WageStructureAndScalePositionId { get; set; }

    public decimal Points { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
