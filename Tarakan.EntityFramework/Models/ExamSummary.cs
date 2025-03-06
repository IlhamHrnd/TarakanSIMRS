using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ExamSummary
{
    public string ExamSummaryId { get; set; }

    public string ExamSummaryName { get; set; }

    public string ExamSummaryNameEng { get; set; }

    public string SrexamSummaryType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
