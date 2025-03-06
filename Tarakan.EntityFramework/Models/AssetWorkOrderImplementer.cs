using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetWorkOrderImplementer
{
    public string OrderNo { get; set; }

    public string UserId { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
