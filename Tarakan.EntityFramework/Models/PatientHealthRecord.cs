using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientHealthRecord
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; } = null!;

    /// <summary>
    /// Examiner
    /// </summary>
    public string EmployeeId { get; set; } = null!;

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ExaminerId { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public string? LetterNo { get; set; }

    public bool? IsClaimDocument { get; set; }
}
