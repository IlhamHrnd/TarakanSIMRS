using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class K3rsFormTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string Result { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
