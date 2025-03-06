using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpFlagItem
{
    public double? No { get; set; }

    public string Id { get; set; }

    public string NamaMaterial { get; set; }

    public string NamaGenerik { get; set; }

    public double? IsFormularium { get; set; }

    public double? IsFornas { get; set; }

    public string IsConsignment { get; set; }

    public double? IsGeneric { get; set; }

    public string IsNarcotic { get; set; }

    public double? IsPsychotropic { get; set; }

    public double? IsAntibiotic { get; set; }

    public string IsPrecursor { get; set; }

    public string IsMorphine { get; set; }

    public string IsHam { get; set; }

    public double? IsLasa { get; set; }

    public string IsOot { get; set; }

    public double? IsHardDrug { get; set; }

    public string IsTraditionalMedicine { get; set; }

    public string IsSupplement { get; set; }

    public double? IsNonGeneric { get; set; }

    public string UkuranKemasanDanSatuanKekuatan { get; set; }
}
