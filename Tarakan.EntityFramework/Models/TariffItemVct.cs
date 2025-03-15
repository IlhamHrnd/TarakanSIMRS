using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TariffItemVct
{
    public string? KodeGroup { get; set; }

    public string? NamaGroup { get; set; }

    public string? KodeItem { get; set; }

    public string? NamaItem { get; set; }

    public string? KodeIdi { get; set; }

    public string? EKlaimTarifGroup { get; set; }

    public double? JasaDokter11 { get; set; }

    public double? Total11 { get; set; }

    public double? JasaDokter21 { get; set; }

    public double? Total21 { get; set; }
}
