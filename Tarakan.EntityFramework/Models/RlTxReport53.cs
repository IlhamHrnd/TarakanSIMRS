using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport53
{
    public string RlTxReportNo { get; set; } = null!;

    public string DiagnosaId { get; set; } = null!;

    public int? KeluarHidupL { get; set; }

    public int? KeluarHidupP { get; set; }

    public int? KeluarMatiL { get; set; }

    public int? KeluarMatiP { get; set; }

    public int? Total { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
