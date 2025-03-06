using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MenuVersion
{
    public string VersionId { get; set; }

    public string VersionName { get; set; }

    public short Cycle { get; set; }

    public bool IsActive { get; set; }

    public bool? IsExtra { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
