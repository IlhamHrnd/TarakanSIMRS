using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemTemplate
{
    public string TemplateNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string? ItemQtyInString { get; set; }

    public string SrdosageUnit { get; set; } = null!;

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public string EmbalaceId { get; set; } = null!;

    public decimal EmbalaceAmount { get; set; }

    public string Notes { get; set; } = null!;

    public string? SrconsumeMethod { get; set; }

    public string? DosageQty { get; set; }

    public string? EmbalaceQty { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? SrmedicationConsume { get; set; }
}
