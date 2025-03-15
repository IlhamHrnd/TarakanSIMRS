using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietComplicationPatient
{
    public string TransactionNo { get; set; } = null!;

    public string DietId { get; set; } = null!;

    public string DietComplicationId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
