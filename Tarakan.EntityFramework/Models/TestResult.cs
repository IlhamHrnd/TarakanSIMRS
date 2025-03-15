using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TestResult
{
    public string TransactionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? ParamedicId { get; set; }

    public DateTime? TestResultDateTime { get; set; }

    public string? TestResult1 { get; set; }

    public string? TestSummary { get; set; }

    public string? TestSuggest { get; set; }

    public string? TestResultOtherLang { get; set; }

    public string? TestSummaryOtherLang { get; set; }

    public string? TestSuggestOtherLang { get; set; }

    public string? TestResultHistory { get; set; }

    public string? TestSummaryHistory { get; set; }

    public string? TestSuggestHistory { get; set; }

    public string? TestResultOtherLangHistory { get; set; }

    public string? TestSummaryOtherLangHistory { get; set; }

    public string? TestSuggestOtherLangHistory { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ClinicalInfo { get; set; }

    public string? SrradiologyCriticalResults { get; set; }

    public long? TestResultTemplateId { get; set; }
}
