using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TariffComponent
{
    public string TariffComponentId { get; set; } = null!;

    public string TariffComponentName { get; set; } = null!;

    public string SrtariffComponentType { get; set; } = null!;

    /// <summary>
    /// Jika ya maka di transakasi harus diisi kode paramedic. Digunakan untuk perhitugan jasa paramedic
    /// </summary>
    public bool? IsTariffParamedic { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Notes { get; set; }

    public bool? IsIncludeInTaxCalc { get; set; }

    public string? SrpphType { get; set; }

    public bool? IsPrintParamedicInSlip { get; set; }

    public bool? IsAutoChecklistCorrectedFeeVerification { get; set; }

    public bool? IsFeeVerificationDefaultSelected { get; set; }
}
