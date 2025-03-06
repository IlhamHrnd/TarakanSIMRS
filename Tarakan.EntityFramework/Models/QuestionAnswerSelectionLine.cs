using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionAnswerSelectionLine
{
    public string QuestionAnswerSelectionId { get; set; }

    public string QuestionAnswerSelectionLineId { get; set; }

    public string QuestionAnswerSelectionLineText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? Score { get; set; }
}
