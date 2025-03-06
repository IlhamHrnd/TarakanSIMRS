using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionAnswerSelection
{
    public string QuestionAnswerSelectionId { get; set; }

    public string QuestionAnswerSelectionText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
