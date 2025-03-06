using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetBook
{
    public string AssetBookId { get; set; }

    public string AssetBookName { get; set; }

    public string DepreciationMethodId { get; set; }

    public string SrassetType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual AssetDepreciationMethod DepreciationMethod { get; set; }
}
