using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport315
{
    public string RlTxReportNo { get; set; }

    public int RlMasterReportItemId { get; set; }

    public int? RiJpk { get; set; }

    public int? RiJld { get; set; }

    public int? Rj { get; set; }

    public int? RjLab { get; set; }

    public int? RjRad { get; set; }

    public int? RjLl { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
