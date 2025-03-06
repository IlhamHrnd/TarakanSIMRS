using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApprovalRangeUser
{
    public string ApprovalRangeId { get; set; }

    public int ApprovalLevel { get; set; }

    public string UserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
