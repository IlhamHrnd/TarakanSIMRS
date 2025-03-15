using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetWorkOrderImplementer
{
    public string OrderNo { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
