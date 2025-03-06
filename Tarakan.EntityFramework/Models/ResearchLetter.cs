using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ResearchLetter
{
    public long LetterId { get; set; }

    public string ResearcherName { get; set; }

    public string LetterNo { get; set; }

    public DateTime LetterDate { get; set; }

    public string Subject { get; set; }

    public string SrresearchDecision { get; set; }

    public string Attachment { get; set; }

    public string SrresearchInstitution { get; set; }

    public string SrresearchFaculty { get; set; }

    public string SrresearchMajors { get; set; }

    public string SreducationDegree { get; set; }

    public bool IsUpload { get; set; }

    public short ReviewTime { get; set; }

    public string SrresearchReviewerName { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
