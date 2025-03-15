using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClinicalPathway
{
    public string RegistrationNo { get; set; } = null!;

    public string PathwayId { get; set; } = null!;

    public int PathwayItemSeqNo { get; set; }

    public int DayNo { get; set; }

    public bool IsRealized { get; set; }

    public DateTime? RealizedDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? SrtransactionCode { get; set; }

    public string? ItemId { get; set; }

    public string? InterventionItemId { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
