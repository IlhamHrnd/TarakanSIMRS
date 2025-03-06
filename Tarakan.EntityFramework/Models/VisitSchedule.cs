using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VisitSchedule
{
    public string ScheduleId { get; set; }

    public string SrscheduleType { get; set; }

    public string PatientId { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string UpdatedByUserId { get; set; }

    public DateTime? UpdatedDateTime { get; set; }
}
