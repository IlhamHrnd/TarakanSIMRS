using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemConsumption
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string DetailItemId { get; set; }

    public decimal Qty { get; set; }

    public decimal? QtyRealization { get; set; }

    public string SritemUnit { get; set; }

    public decimal? Price { get; set; }

    public decimal? AveragePrice { get; set; }

    public decimal? FifoPrice { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsPackage { get; set; }

    public string LocationId { get; set; }
}
