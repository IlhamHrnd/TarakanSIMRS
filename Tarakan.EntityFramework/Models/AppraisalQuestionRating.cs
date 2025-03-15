using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalQuestionRating
{
    public int RatingId { get; set; }

    public int QuestionerId { get; set; }

    public string RatingCode { get; set; } = null!;

    public string RatingName { get; set; } = null!;

    public decimal RatingValue { get; set; }

    public decimal RatingValueMin { get; set; }

    public decimal RatingValueMax { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
