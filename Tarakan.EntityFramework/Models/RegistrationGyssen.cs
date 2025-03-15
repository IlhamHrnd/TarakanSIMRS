using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationGyssen
{
    public string RegistrationNo { get; set; } = null!;

    public int SeqNo { get; set; }

    public string ItemId { get; set; } = null!;

    public string ZatActiveId { get; set; } = null!;

    public string? SrconsumeMethod { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public int? RasproSeqNo { get; set; }

    public string? PrescriptionNo { get; set; }

    public DateTime? PrescriptionDateStart { get; set; }

    public DateTime? PrescriptionDateEnd { get; set; }

    public DateTime? GyssensCreateDateTime { get; set; }

    public string? GyssensCreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
