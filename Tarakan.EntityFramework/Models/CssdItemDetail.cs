using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdItemDetail
{
    public string ItemId { get; set; } = null!;

    public string ItemDetailId { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
