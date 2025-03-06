using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorServiceUnitRule
{
    public string GuarantorId { get; set; }

    public string ServiceUnitId { get; set; }

    public bool? IsCovered { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
