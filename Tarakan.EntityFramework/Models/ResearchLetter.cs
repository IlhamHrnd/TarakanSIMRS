using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ResearchLetter
{
    public long LetterId { get; set; }

    public string ResearcherName { get; set; } = null!;

    public string LetterNo { get; set; } = null!;

    public DateTime LetterDate { get; set; }

    public string Subject { get; set; } = null!;

    public string SrresearchDecision { get; set; } = null!;

    public string Attachment { get; set; } = null!;

    public string SrresearchInstitution { get; set; } = null!;

    public string SrresearchFaculty { get; set; } = null!;

    public string SrresearchMajors { get; set; } = null!;

    public string SreducationDegree { get; set; } = null!;

    public bool IsUpload { get; set; }

    public short ReviewTime { get; set; }

    public string SrresearchReviewerName { get; set; } = null!;

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
