using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItem
{
    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ParentNo { get; set; }

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; }

    public string ItemInterventionId { get; set; }

    public string SritemUnit { get; set; }

    public string ItemQtyInString { get; set; }

    public bool? IsUsingDosageUnit { get; set; }

    public string SrdosageUnit { get; set; }

    public byte? FrequencyOfDosing { get; set; }

    public string DosingPeriod { get; set; }

    public decimal? NumberOfDosage { get; set; }

    public byte? DurationOfDosing { get; set; }

    public string Acpcdc { get; set; }

    public string SrmedicationRoute { get; set; }

    public string ConsumeMethod { get; set; }

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string EmbalaceId { get; set; }

    public decimal EmbalaceAmount { get; set; }

    public bool? IsUseSweetener { get; set; }

    public decimal? SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrdiscountReason { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public decimal DurationRelease { get; set; }

    public decimal? RecipeAmount { get; set; }

    public bool? IsCalcPercentage { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public bool IsUsingAdminReturn { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string LastUpdateByUserHostName { get; set; }

    public string VerifiedByUserHostName { get; set; }

    public string SrconsumeMethod { get; set; }

    public string DosageQty { get; set; }

    public string EmbalaceQty { get; set; }

    public string IterText { get; set; }

    public string OrderText { get; set; }

    public string ConsumeQty { get; set; }

    public string SrconsumeUnit { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceSequenceNo { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public decimal? OriPrescriptionQty { get; set; }

    public string OriConsumeQty { get; set; }

    public string OriSrconsumeUnit { get; set; }

    public decimal? OriResultQty { get; set; }

    public string OriItemQtyInString { get; set; }

    public string OriSritemUnit { get; set; }

    public string OriDosageQty { get; set; }

    public string OriSrdosageUnit { get; set; }

    public string OriSrconsumeMethod { get; set; }

    public bool? IsReturned { get; set; }

    public bool? IsPendingDelivery { get; set; }

    public decimal? DeliveryQty { get; set; }

    public int? DaysOfUsage { get; set; }

    public bool? IsCasemixApproved { get; set; }

    public DateTime? CasemixApprovedDateTime { get; set; }

    public string CasemixApprovedByUserId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public string SrinterventionReason { get; set; }

    public decimal? Qty23Days { get; set; }

    public virtual TransPrescription PrescriptionNoNavigation { get; set; }
}
