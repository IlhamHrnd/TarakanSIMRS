using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionDefaultValue
{
    public string QuestionFormId { get; set; } = null!;

    public string QuestionGroupId { get; set; } = null!;

    public string QuestionId { get; set; } = null!;

    public string? FromQuestionFormId { get; set; }

    public string? FromQuestionGroupId { get; set; }

    public string FromQuestionId { get; set; } = null!;

    public bool? IsFromCurrentRegistration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
