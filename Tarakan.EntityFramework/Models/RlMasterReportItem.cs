using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlMasterReportItem
{
    public int RlMasterReportItemId { get; set; }

    public int RlMasterReportId { get; set; }

    public string RlMasterReportItemNo { get; set; }

    public string RlMasterReportItemCode { get; set; }

    public string RlMasterReportItemName { get; set; }

    public string SrparamedicRl1 { get; set; }

    public bool IsActive { get; set; }

    public string ParameterValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
