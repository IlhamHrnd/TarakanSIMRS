using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IncentiveDetail
{
    public int IncentiveDetailId { get; set; }

    public int IcentiveId { get; set; }

    public bool? IsByEmployeeType { get; set; }

    public string? SremployeeTypeId { get; set; }

    public bool? IsByPositionLevel { get; set; }

    public string? SrpositionLevelId { get; set; }

    public bool? IsByServiceYear { get; set; }

    public decimal? ServiceYearFrom { get; set; }

    public decimal? ServiceYearTo { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
