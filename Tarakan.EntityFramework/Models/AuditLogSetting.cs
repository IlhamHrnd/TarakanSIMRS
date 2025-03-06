using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AuditLogSetting
{
    public string TableName { get; set; }

    public string TableDescription { get; set; }

    public bool IsAuditLog { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsConsolidationBranchToHo { get; set; }

    public bool? IsConsolidationHotoBranch { get; set; }
}
