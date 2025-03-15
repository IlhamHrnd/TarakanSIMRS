using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClinicalExamResult
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
