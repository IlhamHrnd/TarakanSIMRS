using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentItemVisite
{
    public string PaymentNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public int VisiteQty { get; set; }

    public int RealizationQty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ServiceUnitId { get; set; }

    public DateTime? ExpiredDate { get; set; }
}
