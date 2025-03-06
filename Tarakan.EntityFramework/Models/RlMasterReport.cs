using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlMasterReport
{
    public int RlMasterReportId { get; set; }

    public string RlMasterReportNo { get; set; }

    public string RlMasterReportName { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Notes { get; set; }
}
