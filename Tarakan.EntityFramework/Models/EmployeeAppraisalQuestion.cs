using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeAppraisalQuestion
{
    public int EmployeeAppraisalQuestionerId { get; set; }

    public int PersonId { get; set; }

    public int QuestionerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
