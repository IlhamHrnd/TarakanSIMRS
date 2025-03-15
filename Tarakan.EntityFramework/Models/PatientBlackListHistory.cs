using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientBlackListHistory
{
    public string PatientId { get; set; } = null!;

    public bool IsBlackList { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string Notes { get; set; } = null!;
}
