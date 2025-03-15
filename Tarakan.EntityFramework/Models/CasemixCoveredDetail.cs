using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CasemixCoveredDetail
{
    public int CasemixCoveredDetailId { get; set; }

    public int CasemixCoveredId { get; set; }

    public string? ItemId { get; set; }

    public decimal? Qty { get; set; }

    public bool? IsInclude { get; set; }

    public bool? IsNeedCasemixValidate { get; set; }

    public bool? IsAllowedToOrder { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
