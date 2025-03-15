using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalFileStatus
{
    public string PatientId { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string? SrmedicalFileStatusCategory { get; set; }

    public string? SrmedicalFileStatus { get; set; }

    public string? Expeditor { get; set; }

    public string? DepartmentId { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
