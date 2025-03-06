using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SnackOrder
{
    public string SnackOrderNo { get; set; }

    public DateTime SnackOrderDate { get; set; }

    public DateTime SnackOrderForDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
