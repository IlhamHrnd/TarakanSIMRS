﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosa
{
    public string NursingDiagnosaId { get; set; }

    public string NursingDiagnosaName { get; set; }

    public string SrnursingDiagnosaLevel { get; set; }

    public string SequenceNo { get; set; }

    public bool IsActive { get; set; }

    public string NursingDiagnosaParentId { get; set; }

    public string SrnursingNicType { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string RespondTemplate { get; set; }

    public int? TemplateId { get; set; }

    public string SrnsDiagnosaType { get; set; }

    public string SrnsEtiologyType { get; set; }

    public string Prefix { get; set; }

    public string Suffix { get; set; }

    public string NursingDiagnosaCode { get; set; }

    public string F1 { get; set; }

    public string F2 { get; set; }

    public string SrnursingNocType { get; set; }

    public virtual ICollection<NursingAssessmentDiagnosa> NursingAssessmentDiagnosas { get; set; } = new List<NursingAssessmentDiagnosa>();
}
