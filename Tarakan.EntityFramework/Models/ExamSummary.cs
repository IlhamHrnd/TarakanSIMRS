using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ExamSummary
{
    public string ExamSummaryId { get; set; } = null!;

    public string ExamSummaryName { get; set; } = null!;

    public string ExamSummaryNameEng { get; set; } = null!;

    public string SrexamSummaryType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
