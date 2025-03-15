using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DataDtd
{
    public string? KdDtd { get; set; }

    public string? NmDtd { get; set; }

    public string? KetIcd { get; set; }

    public double? NoUrut { get; set; }

    public double? NoSurveilans { get; set; }

    public string? KetSurveilans { get; set; }

    public double? NoSurvLokal { get; set; }

    public string? KetSurvLokal { get; set; }
}
