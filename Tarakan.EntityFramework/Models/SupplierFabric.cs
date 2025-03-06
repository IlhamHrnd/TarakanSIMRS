using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierFabric
{
    public string FabricId { get; set; }

    public string SupplierId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual Fabric Fabric { get; set; }

    public virtual Supplier Supplier { get; set; }
}
