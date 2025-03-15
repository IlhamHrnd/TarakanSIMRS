using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwSpGetNilaiPersediaanAkhirFromMutasiStock
{
    public string ItemName { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal InitialStock { get; set; }

    public decimal QuantityIn { get; set; }

    public decimal QuantityOut { get; set; }

    public decimal LastQuantity { get; set; }
}
