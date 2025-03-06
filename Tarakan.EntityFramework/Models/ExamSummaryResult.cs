using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ExamSummaryResult
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public string SrexamSummaryType { get; set; }

    public string Description { get; set; }

    public int OrderIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
