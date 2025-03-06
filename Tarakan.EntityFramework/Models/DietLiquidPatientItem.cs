using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietLiquidPatientItem
{
    public string TransactionNo { get; set; }

    public string DietTime { get; set; }

    public string ItemId { get; set; }

    public decimal? Qty { get; set; }

    public string SritemUnit { get; set; }

    public string Notes { get; set; }

    public string FoodId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
