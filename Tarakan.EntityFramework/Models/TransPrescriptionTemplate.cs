using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionTemplate
{
    public string TemplateNo { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
