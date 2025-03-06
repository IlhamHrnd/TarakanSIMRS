using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ProductionFormulaOtherItem
{
    public string FormulaId { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
