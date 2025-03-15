using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetItemService
{
    public string ItemId { get; set; } = null!;

    public string AssetId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
