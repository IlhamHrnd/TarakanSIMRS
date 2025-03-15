using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PerformancePlanDocument
{
    public long PerformancePlanDocumentId { get; set; }

    public string PerformancePlanType { get; set; } = null!;

    public long PerformancePlanId { get; set; }

    public string SrquarterPeriod { get; set; } = null!;

    public string? FileAttachName { get; set; }

    public string? DocumentName { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string? Notes { get; set; }

    public byte[]? SmallImage { get; set; }

    public string? OriFileName { get; set; }

    public string? OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
