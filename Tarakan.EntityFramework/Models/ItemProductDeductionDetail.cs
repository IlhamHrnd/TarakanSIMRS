using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductDeductionDetail
{
    public string DeductionId { get; set; }

    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }

    public decimal DeductionAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
