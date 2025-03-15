using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WaitCategory
{
    public int CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public bool? ExcludeFromCollection { get; set; }

    public virtual ICollection<WaitType> WaitTypes { get; set; } = new List<WaitType>();
}
