using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationRasproItem
{
    public string RegistrationNo { get; set; } = null!;

    public int RasproSeqNo { get; set; }

    public string ItemId { get; set; } = null!;

    public string ZatActiveId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public string SrdosageUnit { get; set; } = null!;

    public string? AcPcDc { get; set; }

    public string? SrmedicationRoute { get; set; }

    public string? SrconsumeMethod { get; set; }

    public string? DosageQty { get; set; }

    public string? EmbalaceQty { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime? StartDateTime { get; set; }

    public DateTime? StopDateTime { get; set; }

    public int? PrevRasproSeqNo { get; set; }

    public string? PrevRasproItemId { get; set; }
}
