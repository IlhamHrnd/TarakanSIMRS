using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedicMarginDetail
{
    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public decimal AmountPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
