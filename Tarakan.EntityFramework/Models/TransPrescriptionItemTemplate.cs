using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemTemplate
{
    public string TemplateNo { get; set; }

    public string SequenceNo { get; set; }

    public string ParentNo { get; set; }

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; }

    public string SritemUnit { get; set; }

    public string ItemQtyInString { get; set; }

    public string SrdosageUnit { get; set; }

    public decimal PrescriptionQty { get; set; }

    public decimal TakenQty { get; set; }

    public decimal ResultQty { get; set; }

    public string EmbalaceId { get; set; }

    public decimal EmbalaceAmount { get; set; }

    public string Notes { get; set; }

    public string SrconsumeMethod { get; set; }

    public string DosageQty { get; set; }

    public string EmbalaceQty { get; set; }

    public string ConsumeQty { get; set; }

    public string SrconsumeUnit { get; set; }

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrmedicationConsume { get; set; }
}
