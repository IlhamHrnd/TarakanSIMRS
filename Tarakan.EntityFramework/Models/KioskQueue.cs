using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KioskQueue
{
    public long KioskQueueId { get; set; }

    public string KioskQueueNo { get; set; } = null!;

    public string KioskQueueCode { get; set; } = null!;

    public DateTime KioskQueueDate { get; set; }

    public string SrkioskQueueStatus { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ProcessByUserId { get; set; }

    public DateTime? ProcessDateTime { get; set; }

    public bool? Recall { get; set; }
}
