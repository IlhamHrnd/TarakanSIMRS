using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsPackage
{
    public string PackageId { get; set; }

    public string PackageName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
