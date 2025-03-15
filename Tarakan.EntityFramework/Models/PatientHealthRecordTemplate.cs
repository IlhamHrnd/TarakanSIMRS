using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientHealthRecordTemplate
{
    public string QuestionFormTemplateId { get; set; } = null!;

    public string? QuestionFormId { get; set; }

    public string? TemplateData { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? TemplateName { get; set; }
}
