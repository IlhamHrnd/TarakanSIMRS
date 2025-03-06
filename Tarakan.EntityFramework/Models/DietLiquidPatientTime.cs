using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietLiquidPatientTime
{
    public string TransactionNo { get; set; }

    public string DietTime { get; set; }

    public string FoodId { get; set; }

    public string Measure { get; set; }

    public decimal? AmountOfWater { get; set; }

    public string Etc { get; set; }

    public decimal? Total { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
