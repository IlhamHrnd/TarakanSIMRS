using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalQuestionItem
{
    public int QuestionerItemId { get; set; }

    public int QuestionerId { get; set; }

    public string QuestionCode { get; set; }

    public string QuestionName { get; set; }

    public string QuestionGroupName { get; set; }

    public string Notes { get; set; }

    public decimal? Rating { get; set; }

    public decimal? Benchmark { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Target { get; set; }

    public string Achievements { get; set; }
}
