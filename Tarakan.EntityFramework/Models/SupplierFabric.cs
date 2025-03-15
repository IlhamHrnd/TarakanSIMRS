using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SupplierFabric
{
    public string FabricId { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual Fabric Fabric { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
