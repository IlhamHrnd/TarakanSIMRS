using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AbsentCode
{
    public int AbsentCodeId { get; set; }

    public string AbsentCode1 { get; set; } = null!;

    public string AbsentName { get; set; } = null!;

    public string SrcodeClasification { get; set; } = null!;

    public string SrmanagementType { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsBit { get; set; }
}
