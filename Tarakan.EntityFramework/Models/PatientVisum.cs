using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientVisum
{
    public string VisumId { get; set; } = null!;

    public string VisumType { get; set; } = null!;

    public string? VisumNumber { get; set; }

    public string MedicalRecord { get; set; } = null!;

    public string? PatientName { get; set; }

    public string? BornPlace { get; set; }

    public DateOnly? BornDate { get; set; }

    public string? Religion { get; set; }

    public string? Gender { get; set; }

    public string? Nationality { get; set; }

    public string? Job { get; set; }

    public string? Address { get; set; }

    public string? GnrPol { get; set; }

    public string? GnrNsPol { get; set; }

    public DateOnly? GnrDatePol { get; set; }

    public DateTime? GnrDateChecking { get; set; }

    public string? Results { get; set; }

    public string? Conclusion { get; set; }

    public string? Checker { get; set; }

    public string? IdCheker { get; set; }

    public int? Approval { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public int? ApprovalCheck { get; set; }

    public string? ApprovalCheckBy { get; set; }

    public DateTime? ApprovalCheckDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ApprovalBy { get; set; }
}
