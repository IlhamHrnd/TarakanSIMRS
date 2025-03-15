using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionAnswerSelectionLine
{
    public string QuestionAnswerSelectionId { get; set; } = null!;

    public string QuestionAnswerSelectionLineId { get; set; } = null!;

    public string QuestionAnswerSelectionLineText { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? Score { get; set; }
}
