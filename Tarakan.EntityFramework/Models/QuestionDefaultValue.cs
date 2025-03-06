using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionDefaultValue
{
    public string QuestionFormId { get; set; }

    public string QuestionGroupId { get; set; }

    public string QuestionId { get; set; }

    public string FromQuestionFormId { get; set; }

    public string FromQuestionGroupId { get; set; }

    public string FromQuestionId { get; set; }

    public bool? IsFromCurrentRegistration { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
