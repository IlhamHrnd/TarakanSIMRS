using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlMasterReportItem
{
    public int RlMasterReportItemId { get; set; }

    public int RlMasterReportId { get; set; }

    public string RlMasterReportItemNo { get; set; } = null!;

    public string RlMasterReportItemCode { get; set; } = null!;

    public string RlMasterReportItemName { get; set; } = null!;

    public string SrparamedicRl1 { get; set; } = null!;

    public bool IsActive { get; set; }

    public string ParameterValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
