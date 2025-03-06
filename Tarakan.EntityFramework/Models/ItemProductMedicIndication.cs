using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedicIndication
{
    public string ItemId { get; set; }

    public string IndicationId { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
