using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwItemProductMedicNonMedic
{
    public string ItemId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string SrpurchaseUnit { get; set; } = null!;

    public decimal ConversionFactor { get; set; }

    public bool IsInventoryItem { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWvat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public int? IsRegularItem { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public string? BrandName { get; set; }

    public decimal Dosage { get; set; }

    public string SrdosageUnit { get; set; } = null!;

    public int? IsUsingCigna { get; set; }

    public string SrdrugLabelType { get; set; } = null!;

    public string GenericFlag { get; set; } = null!;

    public bool IsControlExpired { get; set; }

    public int? IsFornas { get; set; }

    public int IsFormularium { get; set; }

    public string Barcode { get; set; } = null!;

    public int? IsAntibiotic { get; set; }

    public int? IsMedication { get; set; }

    public int? IsGeneric { get; set; }

    public int? IsNonGeneric { get; set; }

    public int? IsNonGenericLimited { get; set; }
}
