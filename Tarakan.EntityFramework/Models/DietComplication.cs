using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietComplication
{
    public string DietId { get; set; } = null!;

    public string DietComplicationId { get; set; } = null!;

    public bool IsActive { get; set; }
}
