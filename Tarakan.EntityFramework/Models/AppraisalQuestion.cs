using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalQuestion
{
    public int QuestionerId { get; set; }

    public string? QuestionerNo { get; set; }

    public string? QuestionerName { get; set; }

    public string? PeriodYear { get; set; }

    public decimal? LoadScore { get; set; }

    public string? SranswerRecord { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsScoringRecapitulation { get; set; }
}
