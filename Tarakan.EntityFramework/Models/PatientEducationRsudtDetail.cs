using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientEducationRsudtDetail
{
    public int DetailId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string SreducationTopic { get; set; } = null!;

    public string EducationTopicName { get; set; } = null!;

    public DateTime EducationDateTime { get; set; }

    public string TargetName { get; set; } = null!;

    public string SreducationGivenTo { get; set; } = null!;

    public string EducationGivenToExtraText { get; set; } = null!;

    public string EducatorName { get; set; } = null!;

    public string SreducatorProfession { get; set; } = null!;

    public string EducatorProfessionText { get; set; } = null!;

    public string SreducationInitLvlUnderstanding { get; set; } = null!;

    public string SreducationMedia { get; set; } = null!;

    public string SreducationEvaluation { get; set; } = null!;

    public DateOnly? ReeducationDate { get; set; }

    public byte[]? PatientSign { get; set; }

    public byte[]? PatientSignThumbnail { get; set; }

    public byte[]? EducatorSign { get; set; }

    public byte[]? EducatorSignThumbnail { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
