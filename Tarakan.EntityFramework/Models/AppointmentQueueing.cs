using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentQueueing
{
    public int Id { get; set; }

    public string AppointmentNo { get; set; }

    public string SrqueueingLocation { get; set; }

    public string SrqueueingGroup { get; set; }

    public string SrqueueingType { get; set; }

    public string ServiceUnitId { get; set; }

    public string FormattedNo { get; set; }

    public DateTime QueueingDate { get; set; }

    public string SrkioskQueueStatus { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ProcessByUserId { get; set; }

    public DateTime? ProcessDateTime { get; set; }

    public string CounterCode { get; set; }

    public bool? Recall { get; set; }
}
