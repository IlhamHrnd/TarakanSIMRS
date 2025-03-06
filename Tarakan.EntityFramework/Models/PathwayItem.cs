using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathwayItem
{
    public string PathwayId { get; set; }

    public int PathwayItemSeqNo { get; set; }

    public string ItemId { get; set; }

    public string AssesmentGroupName { get; set; }

    public string AssesmentName { get; set; }

    public decimal CoverageValue1 { get; set; }

    public decimal CoverageValue2 { get; set; }

    public decimal CoverageValue3 { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string AssesmentHeaderName { get; set; }
}
