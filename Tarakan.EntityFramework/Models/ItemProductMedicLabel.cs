using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedicLabel
{
    public string ItemId { get; set; } = null!;

    public string LabelId { get; set; } = null!;

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
