using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicLeaveDate
{
    public string TransactionNo { get; set; }

    public DateTime LeaveDate { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
