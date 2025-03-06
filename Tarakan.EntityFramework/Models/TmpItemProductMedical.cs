using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpItemProductMedical
{
    public string ItemId { get; set; }

    public double? HargaSatuan { get; set; }

    public string ItemName { get; set; }

    public string ItemGroup { get; set; }

    public string SritemUnit { get; set; }

    public string SrpurchaseUnit { get; set; }

    public double? ConversionFactor { get; set; }

    public double? Dosage { get; set; }

    public string SrdosageUnit { get; set; }

    public string BrandName { get; set; }

    public double? PriceInPurchaseUnit { get; set; }

    public double? PriceInBaseUnit { get; set; }

    public double? PriceInBasedUnitWvat { get; set; }

    public double? HighestPriceInBasedUnit { get; set; }

    public double? CostPrice { get; set; }

    public double? IsGeneric { get; set; }

    public double? IsNarcotic { get; set; }

    public double? IsPsychotropic { get; set; }

    public double? IsAntibiotic { get; set; }

    public double? IsRegularItem { get; set; }

    public double? IsHam { get; set; }

    public double? IsLasa { get; set; }

    public double? IsOot { get; set; }

    public double? IsFornas { get; set; }

    public double? IsHardDrug { get; set; }

    public double? IsOtc { get; set; }

    public double? IsTraditionalMedicine { get; set; }

    public double? IsSupplement { get; set; }

    public double? IsNonGeneric { get; set; }
}
