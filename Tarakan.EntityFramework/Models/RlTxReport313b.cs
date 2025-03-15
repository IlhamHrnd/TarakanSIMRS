using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport313b
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemId { get; set; }

    public int? JumlahItemObat { get; set; }

    public int? JumlahItemObatRs { get; set; }

    public int? JumlahItemObatFormulariumRs { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
