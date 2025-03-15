using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalConclusion
{
    public int ConclusionId { get; set; }

    public string? ConclusionName { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
