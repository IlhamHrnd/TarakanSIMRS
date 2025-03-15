using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BakUddItem
{
    public string RegistrationNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParentNo { get; set; } = null!;

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string? ItemQtyInString { get; set; }

    public bool? IsUsingDosageUnit { get; set; }

    public string SrdosageUnit { get; set; } = null!;

    public byte? FrequencyOfDosing { get; set; }

    public string? DosingPeriod { get; set; }

    public decimal? NumberOfDosage { get; set; }

    public byte? DurationOfDosing { get; set; }

    public string? Acpcdc { get; set; }

    public string? SrmedicationRoute { get; set; }

    public string? ConsumeMethod { get; set; }

    public decimal PrescriptionQty { get; set; }

    public string EmbalaceId { get; set; } = null!;

    public bool? IsUseSweetener { get; set; }

    public string Notes { get; set; } = null!;

    public bool IsStop { get; set; }

    public string? SrconsumeMethod { get; set; }

    public string? DosageQty { get; set; }

    public string? EmbalaceQty { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime? StartDateTime { get; set; }

    public DateTime? StopDateTime { get; set; }

    public int? RasproSeqNo { get; set; }

    public int? RasprajaSeqno { get; set; }

    public string? ParamedicId { get; set; }
}
