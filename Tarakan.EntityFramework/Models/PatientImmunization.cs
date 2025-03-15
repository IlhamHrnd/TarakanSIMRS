using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientImmunization
{
    public string PatientId { get; set; } = null!;

    public string ImmunizationId { get; set; } = null!;

    public int ImmunizationNo { get; set; }

    public DateTime? ImmunizationDate { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceItemId { get; set; }

    public string? VaccineId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsDateInMonthYear { get; set; }
}
