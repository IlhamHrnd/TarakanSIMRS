using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingAssessmentTransHd
{
    public long Id { get; set; }

    public string TransactionNo { get; set; }

    public DateTime AssessmentDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string QuestionFormReference { get; set; }
}
