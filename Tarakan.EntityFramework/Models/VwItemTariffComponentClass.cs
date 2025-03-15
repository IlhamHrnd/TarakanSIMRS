using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwItemTariffComponentClass
{
    public string ItemId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;
}
