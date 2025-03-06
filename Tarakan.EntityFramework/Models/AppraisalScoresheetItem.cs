using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalScoresheetItem
{
    public int ScoresheetItemId { get; set; }

    public int ScoresheetId { get; set; }

    public int QuestionerItemId { get; set; }

    public string MarkValue { get; set; }

    public string Notes { get; set; }

    public decimal? Score { get; set; }

    public decimal? RealizationValue { get; set; }

    public decimal? TotalScore { get; set; }

    public decimal? RatingValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
