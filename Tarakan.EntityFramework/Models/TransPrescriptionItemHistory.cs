using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemHistory
{
    public string RecalculationProcessNo { get; set; }

    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ParentNo { get; set; }

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; }

    public string ItemInterventionId { get; set; }

    public string SritemUnit { get; set; }

    public string ItemQtyInString { get; set; }

    public bool IsUsingDosageUnit { get; set; }

    public string SrdosageUnit { get; set; }

    public byte FrequencyOfDosing { get; set; }

    public string DosingPeriod { get; set; }

    public decimal NumberOfDosage { get; set; }

    public byte DurationOfDosing { get; set; }

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

    public bool IsUseSweetener { get; set; }

    public decimal SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrdiscountReason { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public decimal DurationRelease { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public string ConsumeMethodText { get; set; }
}
