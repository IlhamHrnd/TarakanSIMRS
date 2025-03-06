using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetItemService
{
    public string ItemId { get; set; }

    public string AssetId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
