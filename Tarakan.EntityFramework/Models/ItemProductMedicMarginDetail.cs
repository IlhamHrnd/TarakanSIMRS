using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedicMarginDetail
{
    public string ItemId { get; set; }

    public string ClassId { get; set; }

    public decimal AmountPercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
