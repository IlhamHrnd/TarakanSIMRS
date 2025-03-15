using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TariffAmbulance
{
    public string? ItemGroupId { get; set; }

    public string? ItemGroupName { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? KodeIdi { get; set; }

    public string? EKlaimTarifGroup { get; set; }

    public double? Sarana01 { get; set; }

    public double? Total01 { get; set; }

    public double? Sarana02 { get; set; }

    public double? Total02 { get; set; }

    public double? Sarana11 { get; set; }

    public double? Total11 { get; set; }

    public double? Sarana21 { get; set; }

    public double? Total21 { get; set; }

    public double? Sarana31 { get; set; }

    public double? Total31 { get; set; }
}
