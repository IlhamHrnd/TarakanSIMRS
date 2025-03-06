using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport13
{
    public string RlTxReportNo { get; set; }

    public int RlMasterReportItemId { get; set; }

    public int? JumlahTt { get; set; }

    public int? Vvip { get; set; }

    public int? Vip { get; set; }

    public int? I { get; set; }

    public int? Ii { get; set; }

    public int? Iii { get; set; }

    public int? KelasKhusus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
