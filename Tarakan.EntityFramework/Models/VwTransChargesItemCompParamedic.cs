using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransChargesItemCompParamedic
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string ParamedicId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsPackage { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public decimal? CitoAmount { get; set; }

    public string FeeSettledNo { get; set; }
}
