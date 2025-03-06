using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EventMealOrder
{
    public string OrderNo { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime EventDate { get; set; }

    public string EventTime { get; set; }

    public string EventName { get; set; }

    public string Pic { get; set; }

    public short NoOfParticipant { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
