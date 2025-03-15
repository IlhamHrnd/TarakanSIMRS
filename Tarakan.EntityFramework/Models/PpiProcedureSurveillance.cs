using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiProcedureSurveillance
{
    public string BookingNo { get; set; } = null!;

    public bool? IsRiskFactorAge { get; set; }

    public bool? IsRiskFactorNutrient { get; set; }

    public bool? IsRiskFactorObesity { get; set; }

    public bool? IsDiabetes { get; set; }

    public bool? IsHypertension { get; set; }

    public bool? IsHiv { get; set; }

    public bool? IsHbv { get; set; }

    public bool? IsHcv { get; set; }

    public string? SrprocedureClassification { get; set; }

    public string? SrtypesOfSurgery { get; set; }

    public string? SrriskCategory { get; set; }

    public string? SrwoundClassification { get; set; }

    public string? SrasaScore { get; set; }

    public string? Srttime { get; set; }

    public string? Culturs { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
