using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AddMealOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string? ClassId { get; set; }

    public string MenuId { get; set; } = null!;

    public string? MenuItemId { get; set; }

    public string? VersionId { get; set; }

    public string? SeqNo { get; set; }

    public string SrmealSet { get; set; } = null!;

    public short? Qty { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
