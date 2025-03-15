using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesLaboratoryCritical
{
    public string TransactionNo { get; set; } = null!;

    public string LisTestId { get; set; } = null!;

    public string? ReadByPhysicianId { get; set; }

    public DateTime? ReadByPhysicianDateTime { get; set; }

    public string? ReportedByNurseId { get; set; }

    public DateTime? ReportedByNurseDateTime { get; set; }

    public string? CompletelyReportedByUserId { get; set; }

    public DateTime? CompletelyReportedDateTime { get; set; }

    public string? PhysicianNotes { get; set; }

    public string? NurseNotes { get; set; }
}
