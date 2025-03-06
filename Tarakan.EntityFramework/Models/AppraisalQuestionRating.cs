using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalQuestionRating
{
    public int RatingId { get; set; }

    public int QuestionerId { get; set; }

    public string RatingCode { get; set; }

    public string RatingName { get; set; }

    public decimal RatingValue { get; set; }

    public decimal RatingValueMin { get; set; }

    public decimal RatingValueMax { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
