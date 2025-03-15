using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; } = null!;

    public string ItemInterventionId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string ItemQtyInString { get; set; } = null!;

    public bool IsUsingDosageUnit { get; set; }

    public string SrdosageUnit { get; set; } = null!;

    public byte FrequencyOfDosing { get; set; }

    public string DosingPeriod { get; set; } = null!;

    public decimal NumberOfDosage { get; set; }

    public byte DurationOfDosing { get; set; }

    public string Acpcdc { get; set; } = null!;

    public string SrmedicationRoute { get; set; } = null!;

    public string ConsumeMethod { get; set; } = null!;

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string EmbalaceId { get; set; } = null!;

    public decimal EmbalaceAmount { get; set; }

    public bool IsUseSweetener { get; set; }

    public decimal SweetenerAmount { get; set; }

    public decimal LineAmount { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string SrdiscountReason { get; set; } = null!;

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public decimal DurationRelease { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public string? ConsumeMethodText { get; set; }
}
