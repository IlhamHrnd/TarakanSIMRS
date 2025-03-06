using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItem
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public string ItemId { get; set; }

    public string ChargeClassId { get; set; }

    public string ParamedicId { get; set; }

    /// <summary>
    /// Diisi untuk rawat inap oelh Dokter Pengganti atau dokter anestesi
    /// </summary>
    public string SecondParamedicId { get; set; }

    public bool IsAdminCalculation { get; set; }

    public bool IsVariable { get; set; }

    public bool IsCito { get; set; }

    public decimal ChargeQuantity { get; set; }

    public decimal StockQuantity { get; set; }

    public string SritemUnit { get; set; }

    public decimal CostPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal CitoAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public string SrdiscountReason { get; set; }

    public bool? IsAssetUtilization { get; set; }

    public string AssetId { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsOrderRealization { get; set; }

    public bool IsPackage { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; }

    public string FilmNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ParentNo { get; set; }

    public string SrcenterId { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public string ParamedicCollectionName { get; set; }

    public string ToServiceUnitId { get; set; }

    public DateTime? RealizationDateTime { get; set; }

    public string RealizationUserId { get; set; }

    public DateTime? UpdateRealizationDateTime { get; set; }

    public string UpdateRealizationUserId { get; set; }

    public bool? IsCitoInPercent { get; set; }

    public decimal? BasicCitoAmount { get; set; }

    public bool? IsItemRoom { get; set; }

    public bool? IsExtraItem { get; set; }

    public bool? IsSelectedExtraItem { get; set; }

    public bool? IsSendToLis { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsCorrection { get; set; }

    public string ResultValue { get; set; }

    public bool? IsDuplo { get; set; }

    public bool? IsPaymentConfirmed { get; set; }

    public DateTime? PaymentConfirmedDateTime { get; set; }

    public string PaymentConfirmedBy { get; set; }

    public DateTime? LastPaymentConfirmedDateTime { get; set; }

    public string LastPaymentConfirmedByUserId { get; set; }

    public bool? IsDescriptionResult { get; set; }

    public decimal? PriceAdjusted { get; set; }

    public string SrcitoPercentage { get; set; }

    public string ItemConditionRuleId { get; set; }

    public string CommunicationId { get; set; }

    public bool? IsCasemixApproved { get; set; }

    public DateTime? CasemixApprovedDateTime { get; set; }

    public string CasemixApprovedByUserId { get; set; }

    public DateTime? TariffDate { get; set; }

    public DateTime? SpecimenTakenDateTime { get; set; }

    public string SpecimenTakenByUserId { get; set; }

    public DateTime? SpecimenSubmittedDateTime { get; set; }

    public string SpecimenSubmittedByUserId { get; set; }

    public DateTime? SpecimenReceivedDateTime { get; set; }

    public string SpecimenReceivedByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public virtual TransCharge TransactionNoNavigation { get; set; }
}
