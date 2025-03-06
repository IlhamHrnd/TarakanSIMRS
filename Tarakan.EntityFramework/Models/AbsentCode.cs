using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AbsentCode
{
    public int AbsentCodeId { get; set; }

    public string AbsentCode1 { get; set; }

    public string AbsentName { get; set; }

    public string SrcodeClasification { get; set; }

    public string SrmanagementType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsBit { get; set; }
}
