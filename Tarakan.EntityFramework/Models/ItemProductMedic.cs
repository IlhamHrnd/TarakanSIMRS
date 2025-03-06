using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedic
{
    public string ItemId { get; set; }

    public string MarginId { get; set; }

    public string SrproductType { get; set; }

    public string Abcclass { get; set; }

    public string BrandName { get; set; }

    public string SritemUnit { get; set; }

    public string SrpurchaseUnit { get; set; }

    public decimal ConversionFactor { get; set; }

    public decimal Dosage { get; set; }

    public string SrdosageUnit { get; set; }

    public bool IsFormularium { get; set; }

    public bool IsInventoryItem { get; set; }

    public bool IsControlExpired { get; set; }

    public string FabricId { get; set; }

    public decimal SalesFixedPrice { get; set; }

    public decimal MarginPercentage { get; set; }

    public decimal SalesDiscount { get; set; }

    public decimal PriceInPurchaseUnit { get; set; }

    public decimal PriceInBaseUnit { get; set; }

    public decimal PriceInBasedUnitWvat { get; set; }

    public decimal HighestPriceInBasedUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public decimal SafetyStock { get; set; }

    public byte SafetyTime { get; set; }

    public byte LeadTime { get; set; }

    public decimal TolerancePercentage { get; set; }

    public bool? IsUsingCigna { get; set; }

    public string Barcode { get; set; }

    public string SritemBin { get; set; }

    public string SrdrugLabelType { get; set; }

    public bool? IsConsignment { get; set; }

    public string TherapyId { get; set; }

    public bool? IsActualDeduct { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsGeneric { get; set; }

    public decimal? PremiPharmaciesPercentage { get; set; }

    public decimal? PremiPhysicianPercentage { get; set; }

    public decimal? Het { get; set; }

    public string SrproductCategory { get; set; }

    public decimal? LastPriceInBaseUnit { get; set; }

    public bool? IsNarcotic { get; set; }

    public bool? IsPsychotropic { get; set; }

    public bool? IsAntibiotic { get; set; }

    public bool? IsRegularItem { get; set; }

    public bool? IsSalesAvailable { get; set; }

    public bool? IsDirectPurchase { get; set; }

    public decimal PriceWvat { get; set; }

    public bool? IsPrecursor { get; set; }

    public string SrtherapyGroup { get; set; }

    public string Keeping { get; set; }

    public bool? IsMorphine { get; set; }

    public string Srkeeping { get; set; }

    public string Venclass { get; set; }

    public bool? IsHam { get; set; }

    public bool? IsLasa { get; set; }

    public bool? IsOot { get; set; }

    public bool? IsSharePurchaseDiscToPatient { get; set; }

    public bool? IsFornas { get; set; }

    public bool? IsOtc { get; set; }

    public bool? IsHardDrug { get; set; }

    public bool? IsTraditionalMedicine { get; set; }

    public bool? IsSupplement { get; set; }

    public string SrconsumeMethod { get; set; }

    public bool? IsMedication { get; set; }

    public int? ConsumptionLimitInDay { get; set; }

    public bool? IsNonGeneric { get; set; }

    public bool? IsAso { get; set; }

    public string Srroute { get; set; }

    public bool? IsNoPrescriptionFee { get; set; }

    public bool? IsPethidine { get; set; }

    public string SrantibioticLine { get; set; }

    public bool? IsNonGenericLimited { get; set; }

    public virtual Item Item { get; set; }
}
