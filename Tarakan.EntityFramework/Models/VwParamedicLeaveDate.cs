using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwParamedicLeaveDate
{
    public string ParamedicId { get; set; } = null!;

    public DateTime LeaveDate { get; set; }
}
