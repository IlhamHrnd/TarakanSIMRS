using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class FamilyMedicalHistory
{
    public string PatientId { get; set; } = null!;

    public string SrmedicalDisease { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
