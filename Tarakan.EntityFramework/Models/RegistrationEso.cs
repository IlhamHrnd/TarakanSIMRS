using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationEso
{
    public string RegistrationNo { get; set; } = null!;

    public int EsoNo { get; set; }

    public DateTime EsoDateTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public decimal? BodyWeight { get; set; }

    public string? MainDisease { get; set; }

    public string? ParamedicId { get; set; }

    public string? PregnantStatus { get; set; }

    public string? EsoComorbidities { get; set; }

    public string? EsoManifestations { get; set; }

    public string? EsoOtherManifestation { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? SresoStatus { get; set; }

    public string? PrevEsoHistory { get; set; }

    public string? LaboratoryTest { get; set; }

    public int? EsoScaleTotal { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? AssessmentNote { get; set; }
}
