using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AddMealOrder
{
    public string OrderNo { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string MenuId { get; set; }

    public string MenuItemId { get; set; }

    public string VersionId { get; set; }

    public string SeqNo { get; set; }

    public string SrmealSet { get; set; }

    public short? Qty { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
