using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeRemunByIdiDetail
{
    public int RemunDetailId { get; set; }

    public int RemunId { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string? IdiCode { get; set; }

    public decimal Qty { get; set; }

    public decimal Score { get; set; }

    public decimal Rvu { get; set; }

    public decimal? RvuConversion { get; set; }

    public decimal? Coefficient { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SmfId { get; set; }

    public string? ItemGroupId { get; set; }

    public int? SettingId { get; set; }

    public decimal? Multiplier { get; set; }
}
