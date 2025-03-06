using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpAlke
{
    public string ItemId { get; set; }

    public string ItemIdexternal { get; set; }

    public string ItemGroupId { get; set; }

    public double? SritemType { get; set; }

    public string ItemName { get; set; }

    public string MarginId { get; set; }

    public string BrandName { get; set; }

    public string SritemUnit { get; set; }

    public string SrpurchaseUnit { get; set; }

    public double? ConversionFactor { get; set; }

    public double? IsFormularium { get; set; }

    public double? IsInventoryItem { get; set; }

    public double? IsControlExpired { get; set; }

    public double? PriceInPurchaseUnit { get; set; }

    public double? PriceInBaseUnit { get; set; }

    public double? PriceInBasedUnitWvat { get; set; }

    public double? HighestPriceInBasedUnit { get; set; }

    public double? CostPrice { get; set; }

    public double? IsActualDeduct { get; set; }

    public double? IsGeneric { get; set; }

    public double? IsNarcotic { get; set; }

    public double? IsPsychotropic { get; set; }

    public double? IsAntibiotic { get; set; }

    public double? IsRegularItem { get; set; }

    public double? IsSalesAvailable { get; set; }

    public double? IsDirectPurchase { get; set; }

    public double? IsPrecursor { get; set; }

    public double? IsMorphine { get; set; }

    public string Venclass { get; set; }

    public double? IsHam { get; set; }

    public double? IsLasa { get; set; }

    public double? IsOot { get; set; }

    public double? IsSharePurchaseDiscToPatient { get; set; }

    public double? IsFornas { get; set; }

    public double? IsOtc { get; set; }

    public double? IsHardDrug { get; set; }

    public double? IsTraditionalMedicine { get; set; }

    public double? IsSupplement { get; set; }

    public double? IsMedication { get; set; }

    public double? ConsumptionLimitInDay { get; set; }

    public double? IsNonGeneric { get; set; }

    public string IsAso { get; set; }

    public string Srroute { get; set; }
}
