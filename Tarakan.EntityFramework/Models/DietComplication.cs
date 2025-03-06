using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietComplication
{
    public string DietId { get; set; }

    public string DietComplicationId { get; set; }

    public bool IsActive { get; set; }
}
