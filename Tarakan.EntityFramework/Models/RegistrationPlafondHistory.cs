using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPlafondHistory
{
    public long HistoryId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string GuarantorId { get; set; } = null!;

    public decimal PlafondAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
