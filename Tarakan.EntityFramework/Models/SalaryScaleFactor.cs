using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryScaleFactor
{
    public int SalaryScaleFactorId { get; set; }

    public int SalaryScaleId { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
