using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetBook
{
    public string AssetBookId { get; set; } = null!;

    public string AssetBookName { get; set; } = null!;

    public string DepreciationMethodId { get; set; } = null!;

    public string? SrassetType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual AssetDepreciationMethod DepreciationMethod { get; set; } = null!;
}
