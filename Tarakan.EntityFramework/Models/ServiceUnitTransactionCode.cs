using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitTransactionCode
{
    public string ServiceUnitId { get; set; } = null!;

    public string SrtransactionCode { get; set; } = null!;

    public bool? IsItemProductMedic { get; set; }

    public bool? IsItemProductNonMedic { get; set; }

    public bool? IsItemKitchen { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
