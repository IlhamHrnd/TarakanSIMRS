using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMedicZatActive
{
    public string ItemId { get; set; }

    public string ZatActiveId { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsPrinted { get; set; }
}
