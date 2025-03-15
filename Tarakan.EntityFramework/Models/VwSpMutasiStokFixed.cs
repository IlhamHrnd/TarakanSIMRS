using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwSpMutasiStokFixed
{
    public string Periode { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string ItemGroupId { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public string ProductAccountId { get; set; } = null!;

    public string ProductAccountName { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal InitialStock { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public decimal LastQuantity { get; set; }
}
