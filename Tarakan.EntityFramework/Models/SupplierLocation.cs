using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierLocation
{
    public string SupplierId { get; set; }

    public string LocationId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
