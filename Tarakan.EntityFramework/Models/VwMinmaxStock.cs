using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwMinmaxStock
{
    public string LocationId { get; set; }

    public string LocationName { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string SritemType { get; set; }

    public decimal Minimum { get; set; }

    public decimal Maximum { get; set; }

    public decimal Balance { get; set; }

    public bool IsActive { get; set; }
}
