using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductDosageDetail
{
    public string ItemId { get; set; } = null!;

    public decimal Dosage { get; set; }

    public string SrdosageUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
