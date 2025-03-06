using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientHealthRecordDeleted
{
    public string TransactionNo { get; set; }

    public string RegistrationNo { get; set; }

    public string QuestionFormId { get; set; }

    public DateTime RecordDate { get; set; }

    public string RecordTime { get; set; }

    public string EmployeeId { get; set; }

    public bool? IsComplete { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ExaminerId { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string ServiceUnitId { get; set; }

    public string ReferenceNo { get; set; }
}
