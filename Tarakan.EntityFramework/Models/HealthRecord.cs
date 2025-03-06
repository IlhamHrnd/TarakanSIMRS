using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HealthRecord
{
    public string PatientId { get; set; }

    public string QuestionFormId { get; set; }

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; }

    public string EmployeeId { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
