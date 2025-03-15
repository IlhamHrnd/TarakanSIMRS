using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpItemProductMedicGabungan
{
    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemGroupId { get; set; }

    public string? ItemGroupName { get; set; }

    public string? SatuanBesar { get; set; }

    public string? SatuanKecil { get; set; }

    public double? ConversionFactor { get; set; }

    public double? HargaSatuan { get; set; }

    public double? HargaBeli { get; set; }

    public double? Etiket { get; set; }

    public string? IsFormularium { get; set; }

    public string? DistockBukan { get; set; }

    public string? IsControlExpired { get; set; }

    public string? IsGeneric { get; set; }

    public string? IsNarcotic { get; set; }

    public string? IsPsychotropic { get; set; }

    public string? IsAntibiotic { get; set; }

    public string? IsPrecursor { get; set; }

    public string? IsMorphine { get; set; }

    public string? IsHam { get; set; }

    public string? IsLasa { get; set; }

    public string? IsOot { get; set; }
}
