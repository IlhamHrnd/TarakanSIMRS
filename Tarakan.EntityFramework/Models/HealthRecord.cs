using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HealthRecord
{
    public string PatientId { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
