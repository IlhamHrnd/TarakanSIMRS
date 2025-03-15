using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport54
{
    public string RlTxReportNo { get; set; } = null!;

    public string DiagnosaId { get; set; } = null!;

    public int? KasusBaruL { get; set; }

    public int? KasusBaruP { get; set; }

    public int? JumlahKasusBaru { get; set; }

    public int? JumlahKunjungan { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
