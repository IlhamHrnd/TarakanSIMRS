using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTaxCalculationDt
{
    public string VerificationNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public short Period { get; set; }

    public decimal Percentage { get; set; }

    public decimal Gross { get; set; }

    public decimal TaxBaseGross { get; set; }

    public decimal AccumulationTax { get; set; }

    public decimal TaxToBePaid { get; set; }

    public int? CounterId { get; set; }
}
