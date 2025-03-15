using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HealthIndexCofficient
{
    public int Id { get; set; }

    public string HealthIndexCoefficientName { get; set; } = null!;

    public double HealthIndexCoefficientValue { get; set; }

    public DateTime UtclastUpdatedDateTime { get; set; }
}
