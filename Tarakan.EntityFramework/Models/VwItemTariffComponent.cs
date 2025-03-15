using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwItemTariffComponent
{
    public string ItemId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;
}
