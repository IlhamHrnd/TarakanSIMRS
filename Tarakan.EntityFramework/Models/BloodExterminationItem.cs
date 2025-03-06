using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodExterminationItem
{
    public string TransactionNo { get; set; }

    public string BagNo { get; set; }

    public string SrbloodGroup { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
