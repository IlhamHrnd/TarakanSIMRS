using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class OperationNotesTemplate
{
    public int TemplateId { get; set; }

    public string? ParamedicId { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
