using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WilayahRefDinke
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; }

    public int RegencyId { get; set; }

    public string RegencyName { get; set; }

    public int DistrictId { get; set; }

    public string DistrictName { get; set; }

    public long VillageId { get; set; }

    public string VillageName { get; set; }
}
