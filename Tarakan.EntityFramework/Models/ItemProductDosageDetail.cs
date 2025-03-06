using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductDosageDetail
{
    public string ItemId { get; set; }

    public decimal Dosage { get; set; }

    public string SrdosageUnit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
