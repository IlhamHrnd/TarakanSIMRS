using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentQueueing
{
    public int Id { get; set; }

    public string AppointmentNo { get; set; } = null!;

    public string SrqueueingLocation { get; set; } = null!;

    public string SrqueueingGroup { get; set; } = null!;

    public string SrqueueingType { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string FormattedNo { get; set; } = null!;

    public DateTime QueueingDate { get; set; }

    public string SrkioskQueueStatus { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? ProcessByUserId { get; set; }

    public DateTime? ProcessDateTime { get; set; }

    public string? CounterCode { get; set; }

    public bool? Recall { get; set; }
}
