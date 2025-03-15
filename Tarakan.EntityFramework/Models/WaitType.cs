using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WaitType
{
    public int WaitTypeId { get; set; }

    public string WaitType1 { get; set; } = null!;

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public string? HelpLink { get; set; }

    public virtual WaitCategory? Category { get; set; }

    public virtual ICollection<WaitStatisticsDetail> WaitStatisticsDetails { get; set; } = new List<WaitStatisticsDetail>();
}
