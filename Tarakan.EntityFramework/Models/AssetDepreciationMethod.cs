using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetDepreciationMethod
{
    public string DepreciationMethodId { get; set; } = null!;

    public string DepreciationMethodName { get; set; } = null!;

    public decimal Factor { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual ICollection<AssetBook> AssetBooks { get; set; } = new List<AssetBook>();
}
