using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TestResultTemplate
{
    public long TestResultTemplateId { get; set; }

    public string ItemId { get; set; } = null!;

    public string? ParamedicId { get; set; }

    public string TestResultTemplateName { get; set; } = null!;

    public string? TestResult { get; set; }

    public string? TestSummary { get; set; }

    public string? TestSuggest { get; set; }

    public string? TestResultOtherLang { get; set; }

    public string? TestSummaryOtherLang { get; set; }

    public string? TestSuggestOtherLang { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
