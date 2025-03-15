using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WilayahRefDinke
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public int RegencyId { get; set; }

    public string RegencyName { get; set; } = null!;

    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public long VillageId { get; set; }

    public string VillageName { get; set; } = null!;
}
