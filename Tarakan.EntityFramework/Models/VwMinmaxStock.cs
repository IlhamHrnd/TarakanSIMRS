using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwMinmaxStock
{
    public string LocationId { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string ItemGroupId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string SritemType { get; set; } = null!;

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public decimal Balance { get; set; }

    public bool IsActive { get; set; }
}
