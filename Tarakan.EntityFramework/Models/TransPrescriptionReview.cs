using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionReview
{
    public string PrescriptionNo { get; set; } = null!;

    public string SrprescriptionReview { get; set; } = null!;

    public bool? IsPrescriptionReview { get; set; }

    public bool? IsDrugReview { get; set; }

    public string? Note { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? PrescriptionReviewDateTime { get; set; }

    public string? PrescriptionReviewByUserId { get; set; }

    public DateTime? DrugReviewDateTime { get; set; }

    public string? DrugReviewByUserId { get; set; }

    public DateTime? NoteDateTime { get; set; }

    public string? NoteByUserId { get; set; }
}
