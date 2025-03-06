using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietPatientItem
{
    public string TransactionNo { get; set; }

    public string DietId { get; set; }

    public decimal? Calorie { get; set; }

    public decimal? Protein { get; set; }

    public decimal? Fat { get; set; }

    public decimal? Carbohydrate { get; set; }

    public decimal? Salt { get; set; }

    public decimal? Fiber { get; set; }

    public short? ExtraQty { get; set; }

    public string LiquidTime { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
