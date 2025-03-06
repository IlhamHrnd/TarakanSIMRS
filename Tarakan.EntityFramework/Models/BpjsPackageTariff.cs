using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsPackageTariff
{
    public string PackageId { get; set; }

    public DateTime StartingDate { get; set; }

    public string ClassId { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
