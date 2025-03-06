using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport32
{
    public string RlTxReportNo { get; set; }

    public int RlMasterReportItemId { get; set; }

    public int? PasienRujukan { get; set; }

    public int? PasienNonRujukan { get; set; }

    public int? DiRawat { get; set; }

    public int? DiRujuk { get; set; }

    public int? Pulang { get; set; }

    public int? MatiDiUgd { get; set; }

    public int? Doa { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
