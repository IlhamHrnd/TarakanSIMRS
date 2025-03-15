using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitItemService
{
    public string ServiceUnitId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsAllowEditByUserVerificated { get; set; }

    public bool? IsVisible { get; set; }

    public string? IdiCode { get; set; }
}
