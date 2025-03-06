using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UserProgramLog
{
    public long UserProgramLogId { get; set; }

    public long UserLogId { get; set; }

    public string ProgramId { get; set; }

    public DateTime AccessDateTime { get; set; }

    public string Parameter { get; set; }
}
