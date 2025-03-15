using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialQuestionnaire
{
    public int QuestionnaireId { get; set; }

    public string QuestionnaireCode { get; set; } = null!;

    public string QuestionnaireName { get; set; } = null!;

    public string SrprofessionGroup { get; set; } = null!;

    public string SrclinicalWorkArea { get; set; } = null!;

    public string SrclinicalAuthorityLevel { get; set; } = null!;

    public string? Info1 { get; set; }

    public string? Info2 { get; set; }

    public string? Info3 { get; set; }

    public string? Info4 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
