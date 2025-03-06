using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientEducation
{
    public string RegistrationNo { get; set; }

    public int SeqNo { get; set; }

    public DateTime? EducationDateTime { get; set; }

    public string ParamedicId { get; set; }

    public string SruserType { get; set; }

    public string SrpatientEducationProblem { get; set; }

    public string SrpatientEducationMethod { get; set; }

    public string MethodOther { get; set; }

    public string SrpatientEducationRecipient { get; set; }

    public string RecipientName { get; set; }

    public string SrpatientEducationEvaluation { get; set; }

    public int? Duration { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string EducationByUserId { get; set; }

    public string EducationType { get; set; }

    public string ReferenceNo { get; set; }

    public string ReferenceType { get; set; }

    public byte[] FmSign { get; set; }

    public byte[] PsSign { get; set; }
}
